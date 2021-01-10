/////////////////////////////////////////////////////////////////

#include "Button2.h"; //  https://github.com/LennartHennigs/Button2
#include "ESPRotary.h";
//#include "HID-Project.h";
//#include "Keyboard.h";
#include "LiquidCrystal_I2C.h";
#include "AltSoftSerial.h";
# include "Enums.h";

/////////////////////////////////////////////////////////////////

#define ROTARY_PIN1	9
#define ROTARY_PIN2	10
#define BUTTON_PIN	7
#define CLICKS_PER_STEP   4   // this number depends on your rotary encoder 

#define XFER_BUTTON_PIN  12
#define MINOR_BUTTON_PIN  11

/////////////////////////////////////////////////////////////////

AltSoftSerial altSerial;

ESPRotary rotary = ESPRotary(ROTARY_PIN1, ROTARY_PIN2, CLICKS_PER_STEP);
Button2 rotaryButton = Button2(BUTTON_PIN);
Button2 xferButton = Button2(XFER_BUTTON_PIN);
Button2 majorMinorButton = Button2(MINOR_BUTTON_PIN);
LiquidCrystal_I2C lcd(0x27,16,2);  // set the LCD address to 0x27 for a 16 chars and 2 line display

static int previousPosition = 0;
static int majorPostion = true;

char messageBuffer[80];

/////////////////////////////////////////////////////////////////

void setup() {
  Serial.begin(9600);
  altSerial.begin(9600);   // to AltSoftSerial RX
  
  rotary.setChangedHandler(rotate);
  rotary.setLeftRotationHandler(downClick);
  rotary.setRightRotationHandler(upClick);

  rotaryButton.setTapHandler(majorMinor);
  majorMinorButton.setTapHandler(majorMinor);
  xferButton.setTapHandler(xfer);
  //b.setLongClickHandler(resetPosition);

  // init the lcd
  lcd.init();
  lcd.backlight();

  //Keyboard.begin();
  //Gamepad.begin();
}

void loop() {

  //while (!Serial) ;  // wait for Arduino Serial Monitor
  //Gamepad.releaseAll();
  //Gamepad.write();
  
  rotary.loop();
  rotaryButton.loop();
  majorMinorButton.loop();
  xferButton.loop();
  
  if(Serial.available() > 0)
  {
    if (readline(Serial.read(), messageBuffer, 80) > 0) {
          altSerial.print("Msg: >");
          altSerial.print(messageBuffer);
          ProcessMessage(messageBuffer);
          altSerial.println("<");
    }
  }
}

/////////////////////////////////////////////////////////////////


void ProcessMessage(String rawMessage)
{
  // first 3 chars are the code
  MessageType code = rawMessage.substring(0,3).toInt();

  // rest is the data
  String data = rawMessage.substring(3);

  switch(code)
  {
    case COM1ACTV:
      DisplayActiveFreq(PretifyFreq(data));
      break;      

    case COM1STBY:
      DisplayStandbyFreq(PretifyFreq(data));
      break; 

    default:
      altSerial.println("Unknown message recieved: " + rawMessage);
  }  
}


String PretifyFreq(String freq)
{
  // make the freq nice to display
  int diff = 7 - freq.length();
  for(int i = 0; i < diff; i++)
  {
    freq += "0";
  }

  return freq;
}

void DisplayActiveFreq(String freq)
{
    lcd.setCursor(0,0);
    lcd.print(freq);
}

void DisplayStandbyFreq(String freq)
{
    lcd.setCursor(9,0);
    lcd.print(freq);
}

void SendMsg(ActivityType type, String data)
{
  String message = String(type) + data;

  altSerial.print("Sent: ");
  altSerial.println(message); // debugging
  Serial.print(message); // send to PC
  Serial.print(char(3));
}

// on change
void rotate(ESPRotary& r) {
    
    int pos = r.getPosition();

    if(pos > previousPosition)
    {
      altSerial.println("UP");

      //Keyboard.press(modifierA);
      //Keyboard.press(modifierB);
      //Keyboard.press(modifierC);
      //Keyboard.press('2'); 

      if(majorPostion)
      {
        SendMsg(COM1_MAJOR_UP, "major up");  
      }
      else
      {
        SendMsg(COM1_MINOR_UP, "minor up");
      }
    }
    else
    {
      altSerial.println("DOWN");
      
      //Keyboard.press(modifierA);
      //Keyboard.press(modifierB);
      //Keyboard.press(modifierC);
      //Keyboard.press('1');

      if(majorPostion)
      {
        SendMsg(COM1_MAJOR_DOWN, "major down");  
      }
      else
      {
        SendMsg(COM1_MINOR_DOWN, "minor down");
      }
    }

    //delay(45);
    //Keyboard.releaseAll();

    previousPosition = pos;
    //Serial.println("Curr: " + String(pos));

}

// on left or right rotation
void downClick(ESPRotary& r) {
  //Serial.println("Radio down"); 
}

void upClick(ESPRotary& r) {
  //Serial.println("Radio up"); 
}
 
// single click
void majorMinor(Button2& btn) {

  majorPostion = !majorPostion;
  altSerial.println("Major/Minor flip!" + String(majorPostion));

  //Gamepad.press(1);
  //Gamepad.write();
  //delay(45);
  
}

// single click
void xfer(Button2& btn) {
  SendMsg(COM1_SWAP, "swap");  
}

// long click
void resetPosition(Button2& btn) {
  rotary.resetPosition();
  altSerial.println("Reset!");
}

int readline(int readch, char *buffer, int len) {
    static int pos = 0;
    int rpos;

    if (readch > 0) {
        switch (readch) {
            case 3: // ETX - end of text
                rpos = pos;
                pos = 0;  // Reset position index ready for next time
                return rpos;
            default:
                if (pos < len-1) {
                    buffer[pos++] = readch;
                    buffer[pos] = 0;
                }
        }
    }
    return 0;
}




/////////////////////////////////////////////////////////////////
