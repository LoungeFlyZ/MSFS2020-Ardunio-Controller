

using System.Windows.Navigation;

namespace MSFSConnector
{
    public enum SimVars
    {
        NONE,
        ANGLE_OF_ATTACK_INDICATOR,
        GUN_AMMO,
        CANNON_AMMO,
        ROCKET_AMMO,
        BOMB_AMMO,
        LIGHT_ON_STATES,
        LIGHT_STATES,
        LIGHT_PANEL,
        LIGHT_STROBE,
        LIGHT_LANDING,
        STROBE_FLASH,
        LIGHT_TAXI,
        LIGHT_BEACON,
        LIGHT_NAV,
        LIGHT_LOGO,
        LIGHT_WING,
        LIGHT_RECOGNITION,
        LIGHT_CABIN,
        LANDING_LIGHT_PBH,
        LIGHT_NAV_ON,
        LIGHT_BEACON_ON,
        LIGHT_LANDING_ON,
        LIGHT_TAXI_ON,
        LIGHT_STROBE_ON,
        LIGHT_PANEL_ON,
        LIGHT_RECOGNITION_ON,
        LIGHT_WING_ON,
        LIGHT_LOGO_ON,
        LIGHT_CABIN_ON,
        LIGHT_HEAD_ON,
        LIGHT_BRAKE_ON,
        WHEEL_RPM,
        CENTER_WHEEL_RPM,
        LEFT_WHEEL_RPM,
        RIGHT_WHEEL_RPM,
        AUX_WHEEL_RPM,
        WHEEL_ROTATION_ANGLE,
        CENTER_WHEEL_ROTATION_ANGLE,
        LEFT_WHEEL_ROTATION_ANGLE,
        RIGHT_WHEEL_ROTATION_ANGLE,
        AUX_WHEEL_ROTATION_ANGLE,
        SIGMA_SQRT,
        DYNAMIC_PRESSURE,
        TOTAL_VELOCITY,
        TOTAL_WORLD_VELOCITY,
        GROUND_VELOCITY,
        SURFACE_RELATIVE_GROUND_SPEED,
        AIRSPEED_TRUE,
        AIRSPEED_INDICATED,
        AIRSPEED_SELECT_INDICATED_OR_TRUE,
        AIRSPEED_TRUE_CALIBRATE,
        AIRSPEED_BARBER_POLE,
        AIRSPEED_MACH,
        VERTICAL_SPEED,
        VARIOMETER_RATE,
        VARIOMETER_SWITCH,
        MACH_MAX_OPERATE,
        STALL_WARNING,
        OVERSPEED_WARNING,
        BARBER_POLE_MACH,
        VELOCITY_BODY_X,
        VELOCITY_BODY_Y,
        VELOCITY_BODY_Z,
        VELOCITY_WORLD_X,
        VELOCITY_WORLD_Y,
        VELOCITY_WORLD_Z,
        RELATIVE_WIND_VELOCITY_BODY_X,
        RELATIVE_WIND_VELOCITY_BODY_Y,
        RELATIVE_WIND_VELOCITY_BODY_Z,
        ACCELERATION_WORLD_X,
        ACCELERATION_WORLD_Y,
        ACCELERATION_WORLD_Z,
        ACCELERATION_BODY_X,
        ACCELERATION_BODY_Y,
        ACCELERATION_BODY_Z,
        ROTATION_VELOCITY_BODY_X,
        ROTATION_VELOCITY_BODY_Y,
        ROTATION_VELOCITY_BODY_Z,
        DESIGN_SPEED_VS0,
        DESIGN_SPEED_VS1,
        DESIGN_SPEED_VC,
        DESIGN_SPEED_MIN_ROTATION,
        DESIGN_SPEED_CLIMB,
        DESIGN_CRUISE_ALT,
        DESIGN_TAKEOFF_SPEED,
        AI_CONTROLS,
        DELEGATE_CONTROLS_TO_AI,
        MIN_DRAG_VELOCITY,
        PLANE_LATITUDE,
        PLANE_LONGITUDE,
        PLANE_ALTITUDE,
        PLANE_ALT_ABOVE_GROUND,
        PLANE_PITCH_DEGREES,
        PLANE_BANK_DEGREES,
        PLANE_HEADING_DEGREES_MAGNETIC,
        PLANE_HEADING_DEGREES_TRUE,
        INDICATED_ALTITUDE,
        PRESSURE_ALTITUDE,
        KOHLSMAN_SETTING_MB,
        KOHLSMAN_SETTING_HG,
        ATTITUDE_INDICATOR_PITCH_DEGREES,
        ATTITUDE_INDICATOR_BANK_DEGREES,
        ATTITUDE_BARS_POSITION,
        ATTITUDE_CAGE,
        MAGVAR,
        WISKEY_COMPASS_INDICATION_DEGREES,
        MAGNETIC_COMPASS,
        PLANE_HEADING_DEGREES_GYRO,
        GYRO_DRIFT_ERROR,
        DELTA_HEADING_RATE,
        TURN_INDICATOR_RATE,
        TURN_INDICATOR_SWITCH,
        GROUND_ALTITUDE,
        SIM_ON_GROUND,
        SIM_SHOULD_SET_ON_GROUND,
        TURN_COORDINATOR_BALL,
        YOKE_Y_POSITION,
        YOKE_Y_INDICATOR,
        YOKE_X_POSITION,
        YOKE_X_INIDICATOR,
        YOKE_X_INDICATOR,
        AILERON_POSITION,
        RUDDER_PEDAL_POSITION,
        RUDDER_PEDAL_INDICATOR,
        RUDDER_POSITION,
        ELEVATOR_POSITION,
        ELEVATOR_TRIM_POSITION,
        ELEVATOR_TRIM_INDICATOR,
        ELEVATOR_TRIM_PCT,
        BRAKE_LEFT_POSITION,
        BRAKE_RIGHT_POSITION,
        BRAKE_INDICATOR,
        BRAKE_PARKING_POSITION,
        BRAKE_PARKING_INDICATOR,
        BRAKE_DEPENDENT_HYDRAULIC_PRESSURE,
        SPOILERS_ARMED,
        SPOILERS_HANDLE_POSITION,
        SPOILERS_LEFT_POSITION,
        SPOILERS_RIGHT_POSITION,
        FLY_BY_WIRE_ELAC_SWITCH,
        FLY_BY_WIRE_FAC_SWITCH,
        FLY_BY_WIRE_SEC_SWITCH,
        FLY_BY_WIRE_ELAC_FAILED,
        FLY_BY_WIRE_FAC_FAILED,
        FLY_BY_WIRE_SEC_FAILED,
        FLY_BY_WIRE_ALPHA_PROTECTION,
        FLAPS_NUM_HANDLE_POSITIONS,
        FLAPS_HANDLE_PERCENT,
        FLAPS_HANDLE_INDEX,
        TRAILING_EDGE_FLAPS_LEFT_PERCENT,
        TRAILING_EDGE_FLAPS_RIGHT_PERCENT,
        LEADING_EDGE_FLAPS_LEFT_PERCENT,
        LEADING_EDGE_FLAPS_RIGHT_PERCENT,
        TRAILING_EDGE_FLAPS_LEFT_ANGLE,
        TRAILING_EDGE_FLAPS_RIGHT_ANGLE,
        LEADING_EDGE_FLAPS_LEFT_ANGLE,
        LEADING_EDGE_FLAPS_RIGHT_ANGLE,
        FLAP_POSITION_SET,
        IS_GEAR_RETRACTABLE,
        IS_GEAR_WHEELS,
        IS_GEAR_SKIS,
        IS_GEAR_FLOATS,
        IS_GEAR_SKIDS,
        GEAR_HANDLE_POSITION,
        GEAR_EMERGENCY_HANDLE_POSITION,
        GEAR_CENTER_POSITION,
        GEAR_LEFT_POSITION,
        GEAR_RIGHT_POSITION,
        GEAR_TAIL_POSITION,
        GEAR_AUX_POSITION,
        GEAR_POSITION,
        GEAR_ANIMATION_POSITION,
        GEAR_TOTAL_PCT_EXTENDED,
        GEAR_WARNING,
        TAILWHEEL_LOCK_ON,
        NOSEWHEEL_LOCK_ON,
        COWL_FLAPS,
        AVIONICS_MASTER_SWITCH,
        PANEL_AUTO_FEATHER_SWITCH,
        PANEL_ANTI_ICE_SWITCH,
        AUTO_BRAKE_SWITCH_CB,
        ANTISKID_BRAKES_ACTIVE,
        WATER_RUDDER_HANDLE_POSITION,
        WATER_LEFT_RUDDER_EXTENDED,
        WATER_RIGHT_RUDDER_EXTENDED,
        RETRACT_FLOAT_SWITCH,
        RETRACT_LEFT_FLOAT_EXTENDED,
        RETRACT_RIGHT_FLOAT_EXTENDED,
        GEAR_CENTER_STEER_ANGLE,
        GEAR_LEFT_STEER_ANGLE,
        GEAR_RIGHT_STEER_ANGLE,
        GEAR_AUX_STEER_ANGLE,
        GEAR_STEER_ANGLE,
        WATER_LEFT_RUDDER_STEER_ANGLE,
        WATER_RIGHT_RUDDER_STEER_ANGLE,
        GEAR_CENTER_STEER_ANGLE_PCT,
        GEAR_LEFT_STEER_ANGLE_PCT,
        GEAR_RIGHT_STEER_ANGLE_PCT,
        GEAR_AUX_STEER_ANGLE_PCT,
        GEAR_STEER_ANGLE_PCT,
        WATER_LEFT_RUDDER_STEER_ANGLE_PCT,
        WATER_RIGHT_RUDDER_STEER_ANGLE_PCT,
        STEER_INPUT_CONTROL,
        ELEVATOR_DEFLECTION,
        ELEVATOR_DEFLECTION_PCT,
        AILERON_LEFT_DEFLECTION,
        AILERON_LEFT_DEFLECTION_PCT,
        AILERON_RIGHT_DEFLECTION,
        AILERON_RIGHT_DEFLECTION_PCT,
        AILERON_AVERAGE_DEFLECTION,
        AILERON_TRIM,
        AILERON_TRIM_PCT,
        RUDDER_DEFLECTION,
        RUDDER_DEFLECTION_PCT,
        RUDDER_TRIM,
        RUDDER_TRIM_PCT,
        WING_FLEX_PCT,
        WING_AREA,
        WING_SPAN,
        PROP_SYNC_ACTIVE,
        INCIDENCE_ALPHA,
        INCIDENCE_BETA,
        BETA_DOT,
        LINEAR_CL_ALPHA,
        STALL_ALPHA,
        ZERO_LIFT_ALPHA,
        CG_PERCENT,
        CG_PERCENT_LATERAL,
        CG_AFT_LIMIT,
        CG_FWD_LIMIT,
        CG_MAX_MACH,
        CG_MIN_MACH,
        PAYLOAD_STATION_WEIGHT,
        PAYLOAD_STATION_NAME,
        PAYLOAD_STATION_COUNT,
        PAYLOAD_STATION_OBJECT,
        PAYLOAD_STATION_NUM_SIMOBJECTS,
        ELEVON_DEFLECTION,
        FOLDING_WING_LEFT_PERCENT,
        FOLDING_WING_RIGHT_PERCENT,
        FOLDING_WING_HANDLE_POSITION,
        CANOPY_OPEN,
        TAILHOOK_POSITION,
        TAILHOOK_HANDLE,
        LAUNCHBAR_POSITION,
        LAUNCHBAR_SWITCH,
        LAUNCHBAR_HELD_EXTENDED,
        EXIT_OPEN,
        EXIT_TYPE,
        EXIT_POSX,
        EXIT_POSY,
        EXIT_POSZ,
        RADIO_HEIGHT,
        DECISION_HEIGHT,
        DECISION_ALTITUDE_MSL,
        TOTAL_WEIGHT,
        MAX_GROSS_WEIGHT,
        EMPTY_WEIGHT,
        EMPTY_WEIGHT_PITCH_MOI,
        EMPTY_WEIGHT_ROLL_MOI,
        EMPTY_WEIGHT_YAW_MOI,
        EMPTY_WEIGHT_CROSS_COUPLED_MOI,
        TOTAL_WEIGHT_PITCH_MOI,
        TOTAL_WEIGHT_ROLL_MOI,
        TOTAL_WEIGHT_YAW_MOI,
        TOTAL_WEIGHT_CROSS_COUPLED_MOI,
        WATER_BALLAST_VALVE,
        AUTOPILOT_MASTER,
        AUTOPILOT_WING_LEVELER,
        AUTOPILOT_NAV1_LOCK,
        AUTOPILOT_HEADING_LOCK,
        AUTOPILOT_HEADING_LOCK_DIR,
        AUTOPILOT_ALTITUDE_LOCK,
        AUTOPILOT_ALTITUDE_LOCK_VAR,
        AUTOPILOT_ATTITUDE_HOLD,
        AUTOPILOT_GLIDESLOPE_HOLD,
        AUTOPILOT_APPROACH_HOLD,
        AUTOPILOT_BACKCOURSE_HOLD,
        AUTOPILOT_YAW_DAMPER,
        AUTOPILOT_AIRSPEED_HOLD,
        AUTOPILOT_AIRSPEED_HOLD_VAR,
        AUTOPILOT_MACH_HOLD,
        AUTOPILOT_MACH_HOLD_VAR,
        AUTOPILOT_VERTICAL_HOLD,
        AUTOPILOT_VERTICAL_HOLD_VAR,
        AUTOPILOT_ALTITUDE_MANUALLY_TUNABLE,
        AUTOPILOT_HEADING_MANUALLY_TUNABLE,
        AUTOPILOT_THROTTLE_ARM,
        AUTOPILOT_TAKEOFF_POWER_ACTIVE,
        AUTOPILOT_RPM_HOLD,
        AUTOPILOT_RPM_HOLD_VAR,
        AUTOPILOT_SPEED_SETTING,
        AUTOPILOT_AIRSPEED_ACQUISITION,
        AUTOPILOT_AIRSPEED_HOLD_CURRENT,
        AUTOPILOT_MAX_SPEED_HOLD,
        AUTOPILOT_CRUISE_SPEED_HOLD,
        AUTOPILOT_FLIGHT_DIRECTOR_ACTIVE,
        AUTOPILOT_FLIGHT_DIRECTOR_PITCH,
        AUTOPILOT_FLIGHT_DIRECTOR_BANK,
        AUTOPILOT_PITCH_HOLD,
        AUTOPILOT_PITCH_HOLD_REF,
        AUTOPILOT_NAV_SELECTED,
        GPS_DRIVES_NAV1,
        AUTOTHROTTLE_ACTIVE,
        AUTOPILOT_MAX_BANK,
        NUMBER_OF_CATAPULTS,
        HOLDBACK_BAR_INSTALLED,
        BLAST_SHIELD_POSITION,
        CATAPULT_STROKE_POSITION,
        ENGINE_CONTROL_SELECT,
        NUMBER_OF_ENGINES,
        MAX_RATED_ENGINE_RPM,
        PROPELLER_ADVANCED_SELECTION,
        THROTTLE_LOWER_LIMIT,
        OIL_AMOUNT,
        ENGINE_PRIMER,
        ENGINE_TYPE,
        ENG_RPM_ANIMATION_PERCENT,
        FULL_THROTTLE_THRUST_TO_WEIGHT_RATIO,
        PROP_RPM,
        PROP_MAX_RPM_PERCENT,
        PROP_THRUST,
        PROP_BETA,
        PROP_FEATHERING_INHIBIT,
        PROP_FEATHERED,
        PROP_SYNC_DELTA_LEVER,
        PROP_AUTO_FEATHER_ARMED,
        PROP_FEATHER_SWITCH,
        PROP_AUTO_CRUISE_ACTIVE,
        PROP_ROTATION_ANGLE,
        PROP_BETA_MAX,
        PROP_BETA_MIN,
        PROP_BETA_MIN_REVERSE,
        MASTER_IGNITION_SWITCH,
        ENG_COMBUSTION,
        OLD_ENG_STARTER,
        ENG_N1_RPM,
        ENG_N2_RPM,
        ENG_FUEL_FLOW_GPH,
        ENG_FUEL_FLOW_PPH,
        ENG_FUEL_FLOW_PPH_SSL,
        ENG_TORQUE,
        ENG_ANTI_ICE,
        ENG_PRESSURE_RATIO,
        ENG_PRESSURE_RATIO_GES,
        ENG_EXHAUST_GAS_TEMPERATURE,
        ENG_EXHAUST_GAS_TEMPERATURE_GES,
        ENG_CYLINDER_HEAD_TEMPERATURE,
        ENG_OIL_TEMPERATURE,
        ENG_OIL_PRESSURE,
        ENG_OIL_QUANTITY,
        ENG_HYDRAULIC_PRESSURE,
        ENG_HYDRAULIC_QUANTITY,
        ENG_MANIFOLD_PRESSURE,
        ENG_VIBRATION,
        ENG_RPM_SCALER,
        ENG_TURBINE_TEMPERATURE,
        ENG_TORQUE_PERCENT,
        ENG_FUEL_PRESSURE,
        ENG_ELECTRICAL_LOAD,
        ENG_TRANSMISSION_PRESSURE,
        ENG_TRANSMISSION_TEMPERATURE,
        ENG_ROTOR_RPM,
        ENG_FUEL_FLOW_BUG_POSITION,
        ENG_MAX_RPM,
        ENG_ON_FIRE,
        GENERAL_ENG_COMBUSTION,
        GENERAL_ENG_MASTER_ALTERNATOR,
        GENERAL_ENG_FUEL_PUMP_SWITCH,
        GENERAL_ENG_FUEL_PUMP_ON,
        GENERAL_ENG_RPM,
        GENERAL_ENG_PCT_MAX_RPM,
        GENERAL_ENG_MAX_REACHED_RPM,
        GENERAL_ENG_THROTTLE_LEVER_POSITION,
        GENERAL_ENG_MIXTURE_LEVER_POSITION,
        GENERAL_ENG_PROPELLER_LEVER_POSITION,
        GENERAL_ENG_STARTER,
        GENERAL_ENG_STARTER_ACTIVE,
        GENERAL_ENG_EXHAUST_GAS_TEMPERATURE,
        GENERAL_ENG_OIL_PRESSURE,
        GENERAL_ENG_OIL_LEAKED_PERCENT,
        GENERAL_ENG_COMBUSTION_SOUND_PERCENT,
        GENERAL_ENG_DAMAGE_PERCENT,
        GENERAL_ENG_OIL_TEMPERATURE,
        GENERAL_ENG_FAILED,
        GENERAL_ENG_GENERATOR_SWITCH,
        GENERAL_ENG_GENERATOR_ACTIVE,
        GENERAL_ENG_ANTI_ICE_POSITION,
        GENERAL_ENG_FUEL_VALVE,
        GENERAL_ENG_FUEL_PRESSURE,
        GENERAL_ENG_ELAPSED_TIME,
        GENERAL_ENG_FIRE_DETECTED,
        GENERAL_ENG_FUEL_USED_SINCE_START,
        RECIP_ENG_COWL_FLAP_POSITION,
        RECIP_ENG_PRIMER,
        RECIP_ENG_MANIFOLD_PRESSURE,
        RECIP_ENG_ALTERNATE_AIR_POSITION,
        RECIP_ENG_COOLANT_RESERVOIR_PERCENT,
        RECIP_ENG_LEFT_MAGNETO,
        RECIP_ENG_RIGHT_MAGNETO,
        RECIP_ENG_BRAKE_POWER,
        RECIP_ENG_STARTER_TORQUE,
        RECIP_ENG_TURBOCHARGER_FAILED,
        RECIP_ENG_EMERGENCY_BOOST_ACTIVE,
        RECIP_ENG_EMERGENCY_BOOST_ELAPSED_TIME,
        RECIP_ENG_WASTEGATE_POSITION,
        RECIP_ENG_TURBINE_INLET_TEMPERATURE,
        RECIP_ENG_CYLINDER_HEAD_TEMPERATURE,
        RECIP_ENG_RADIATOR_TEMPERATURE,
        RECIP_ENG_FUEL_AVAILABLE,
        RECIP_ENG_FUEL_FLOW,
        RECIP_ENG_FUEL_TANK_SELECTOR,
        RECIP_ENG_FUEL_TANKS_USED,
        RECIP_ENG_FUEL_NUMBER_TANKS_USED,
        RECIP_ENG_DETONATING,
        RECIP_ENG_CYLINDER_HEALTH,
        RECIP_ENG_NUM_CYLINDERS,
        RECIP_ENG_NUM_CYLINDERS_FAILED,
        RECIP_CARBURETOR_TEMPERATURE,
        RECIP_MIXTURE_RATIO,
        RECIP_ENG_ANTIDETONATION_TANK_VALVE,
        RECIP_ENG_ANTIDETONATION_TANK_QUANTITY,
        RECIP_ENG_ANTIDETONATION_TANK_MAX_QUANTITY,
        RECIP_ENG_NITROUS_TANK_VALVE,
        RECIP_ENG_NITROUS_TANK_QUANTITY,
        RECIP_ENG_NITROUS_TANK_MAX_QUANTITY,
        TURB_ENG_N1,
        TURB_ENG_N2,
        TURB_ENG_CORRECTED_N1,
        TURB_ENG_CORRECTED_N2,
        TURB_ENG_CORRECTED_FF,
        TURB_ENG_MAX_TORQUE_PERCENT,
        TURB_ENG_PRESSURE_RATIO,
        TURB_ENG_ITT,
        TURB_ENG_AFTERBURNER,
        TURB_ENG_AFTERBURNER_STAGE_ACTIVE,
        TURB_ENG_AFTERBURNER_PCT_ACTIVE,
        TURB_ENG_JET_THRUST,
        TURB_ENG_BLEED_AIR,
        TURB_ENG_TANK_SELECTOR,
        TURB_ENG_TANKS_USED,
        TURB_ENG_NUM_TANKS_USED,
        TURB_ENG_FUEL_FLOW_PPH,
        TURB_ENG_FUEL_AVAILABLE,
        TURB_ENG_PRIMARY_NOZZLE_PERCENT,
        TURB_ENG_REVERSE_NOZZLE_PERCENT,
        TURB_ENG_VIBRATION,
        TURB_ENG_IGNITION_SWITCH,
        TURB_ENG_MASTER_STARTER_SWITCH,
        ENG_FAILED,
        PARTIAL_PANEL_ADF,
        PARTIAL_PANEL_AIRSPEED,
        PARTIAL_PANEL_ALTIMETER,
        PARTIAL_PANEL_ATTITUDE,
        PARTIAL_PANEL_COMM,
        PARTIAL_PANEL_COMPASS,
        PARTIAL_PANEL_ELECTRICAL,
        PARTIAL_PANEL_AVIONICS,
        PARTIAL_PANEL_ENGINE,
        PARTIAL_PANEL_FUEL_INDICATOR,
        PARTIAL_PANEL_HEADING,
        PARTIAL_PANEL_VERTICAL_VELOCITY,
        PARTIAL_PANEL_TRANSPONDER,
        PARTIAL_PANEL_NAV,
        PARTIAL_PANEL_PITOT,
        PARTIAL_PANEL_TURN_COORDINATOR,
        PARTIAL_PANEL_VACUUM,
        FUEL_TANK_CENTER_LEVEL,
        FUEL_TANK_CENTER_CAPACITY,
        FUEL_TANK_CENTER_QUANTITY,
        FUEL_TANK_CENTER2_LEVEL,
        FUEL_TANK_CENTER2_CAPACITY,
        FUEL_TANK_CENTER2_QUANTITY,
        FUEL_TANK_CENTER3_LEVEL,
        FUEL_TANK_CENTER3_CAPACITY,
        FUEL_TANK_CENTER3_QUANTITY,
        FUEL_TANK_LEFT_MAIN_LEVEL,
        FUEL_TANK_LEFT_MAIN_CAPACITY,
        FUEL_TANK_LEFT_MAIN_QUANTITY,
        FUEL_TANK_LEFT_AUX_LEVEL,
        FUEL_TANK_LEFT_AUX_CAPACITY,
        FUEL_TANK_LEFT_AUX_QUANTITY,
        FUEL_TANK_LEFT_TIP_LEVEL,
        FUEL_TANK_LEFT_TIP_CAPACITY,
        FUEL_TANK_LEFT_TIP_QUANTITY,
        FUEL_LEFT_QUANTITY,
        FUEL_TANK_RIGHT_MAIN_LEVEL,
        FUEL_TANK_RIGHT_MAIN_CAPACITY,
        FUEL_TANK_RIGHT_MAIN_QUANTITY,
        FUEL_TANK_RIGHT_AUX_LEVEL,
        FUEL_TANK_RIGHT_AUX_CAPACITY,
        FUEL_TANK_RIGHT_AUX_QUANTITY,
        FUEL_TANK_RIGHT_TIP_LEVEL,
        FUEL_TANK_RIGHT_TIP_CAPACITY,
        FUEL_TANK_RIGHT_TIP_QUANTITY,
        FUEL_RIGHT_QUANTITY,
        FUEL_TANK_EXTERNAL1_LEVEL,
        FUEL_TANK_EXTERNAL1_CAPACITY,
        FUEL_TANK_EXTERNAL1_QUANTITY,
        FUEL_TANK_EXTERNAL2_LEVEL,
        FUEL_TANK_EXTERNAL2_CAPACITY,
        FUEL_TANK_EXTERNAL2_QUANTITY,
        FUEL_TOTAL_QUANTITY,
        FUEL_TOTAL_CAPACITY,
        FUEL_LEFT_CAPACITY,
        FUEL_RIGHT_CAPACITY,
        FUEL_WEIGHT_PER_GALLON,
        FUEL_TANK_SELECTOR,
        FUEL_CROSS_FEED,
        NUM_FUEL_SELECTORS,
        FUEL_SELECTED_QUANTITY_PERCENT,
        FUEL_SELECTED_QUANTITY,
        FUEL_TOTAL_QUANTITY_WEIGHT,
        FUEL_SELECTED_TRANSFER_MODE,
        FUEL_DUMP_SWITCH,
        FUEL_DUMP_ACTIVE,
        DROPPABLE_OBJECTS_COUNT,
        DROPPABLE_OBJECTS_TYPE,
        DROPPABLE_OBJECTS_UI_NAME,
        WARNING_FUEL,
        WARNING_FUEL_LEFT,
        WARNING_FUEL_RIGHT,
        WARNING_VACUUM,
        WARNING_VACUUM_LEFT,
        WARNING_VACUUM_RIGHT,
        WARNING_OIL_PRESSURE,
        WARNING_VOLTAGE,
        WARNING_LOW_HEIGHT,
        AUTOPILOT_AVAILABLE,
        FLAPS_AVAILABLE,
        STALL_HORN_AVAILABLE,
        ENGINE_MIXURE_AVAILABLE,
        CARB_HEAT_AVAILABLE,
        SPOILER_AVAILABLE,
        STROBES_AVAILABLE,
        PROP_TYPE_AVAILABLE,
        TOE_BRAKES_AVAILABLE,
        IS_TAIL_DRAGGER,
        SYSTEMS_AVAILABLE,
        INSTRUMENTS_AVAILABLE,
        FUEL_PUMP,
        MANUAL_FUEL_PUMP_HANDLE,
        ALTERNATE_STATIC_SOURCE_OPEN,
        BLEED_AIR_SOURCE_CONTROL,
        ELECTRICAL_MASTER_BATTERY,
        ELECTRICAL_OLD_CHARGING_AMPS,
        ELECTRICAL_TOTAL_LOAD_AMPS,
        ELECTRICAL_BATTERY_LOAD,
        ELECTRICAL_BATTERY_VOLTAGE,
        ELECTRICAL_MAIN_BUS_VOLTAGE,
        ELECTRICAL_MAIN_BUS_AMPS,
        ELECTRICAL_AVIONICS_BUS_VOLTAGE,
        ELECTRICAL_AVIONICS_BUS_AMPS,
        ELECTRICAL_HOT_BATTERY_BUS_VOLTAGE,
        ELECTRICAL_HOT_BATTERY_BUS_AMPS,
        ELECTRICAL_BATTERY_BUS_VOLTAGE,
        ELECTRICAL_BATTERY_BUS_AMPS,
        ELECTRICAL_GENALT_BUS_VOLTAGE,
        ELECTRICAL_GENALT_BUS_AMPS,
        CIRCUIT_GENERAL_PANEL_ON,
        CIRCUIT_FLAP_MOTOR_ON,
        CIRCUIT_GEAR_MOTOR_ON,
        CIRCUIT_AUTOPILOT_ON,
        CIRCUIT_AVIONICS_ON,
        CIRCUIT_PITOT_HEAT_ON,
        CIRCUIT_PROP_SYNC_ON,
        CIRCUIT_AUTO_FEATHER_ON,
        CIRCUIT_AUTO_BRAKES_ON,
        CIRCUIT_STANDY_VACUUM_ON,
        CIRCUIT_STANDBY_VACUUM_ON,
        CIRCUIT_MARKER_BEACON_ON,
        CIRCUIT_GEAR_WARNING_ON,
        CIRCUIT_HYDRAULIC_PUMP_ON,
        AMBIENT_DENSITY,
        AMBIENT_TEMPERATURE,
        AMBIENT_PRESSURE,
        AMBIENT_WIND_VELOCITY,
        AMBIENT_WIND_DIRECTION,
        AMBIENT_WIND_X,
        AMBIENT_WIND_Y,
        AMBIENT_WIND_Z,
        AMBIENT_PRECIP_STATE,
        AMBIENT_IN_CLOUD,
        AMBIENT_VISIBILITY,
        BAROMETER_PRESSURE,
        SEA_LEVEL_PRESSURE,
        TOTAL_AIR_TEMPERATURE,
        STANDARD_ATM_TEMPERATURE,
        AIRCRAFT_WIND_X,
        AIRCRAFT_WIND_Y,
        AIRCRAFT_WIND_Z,
        HYDRAULIC_PRESSURE,
        HYDRAULIC_RESERVOIR_PERCENT,
        HYDRAULIC_SYSTEM_INTEGRITY,
        HYDRAULIC_SWITCH,
        GEAR_HYDRAULIC_PRESSURE,
        CONCORDE_VISOR_NOSE_HANDLE,
        CONCORDE_VISOR_POSITION_PERCENT,
        CONCORDE_NOSE_ANGLE,
        RADIOS_AVAILABLE,
        COM_TRANSMIT,
        COM_RECEIVE_ALL,
        COM_RECIEVE_ALL,
        NAV_SOUND,
        DME_SOUND,
        ADF_SOUND,
        ADF_CARD,
        MARKER_SOUND,
        COM_AVAILABLE,
        COM_ACTIVE_FREQUENCY,
        COM_STANDBY_FREQUENCY,
        COM_STATUS,
        COM_TEST,
        TRANSPONDER_AVAILABLE,
        TRANSPONDER_CODE,
        ADF_AVAILABLE,
        ADF_FREQUENCY,
        ADF_EXT_FREQUENCY,
        ADF_ACTIVE_FREQUENCY,
        ADF_STANDBY_FREQUENCY,
        ADF_LATLONALT,
        ADF_SIGNAL,
        ADF_RADIAL,
        ADF_IDENT,
        ADF_NAME,
        NAV_AVAILABLE,
        NAV_ACTIVE_FREQUENCY,
        NAV_STANDBY_FREQUENCY,
        NAV_SIGNAL,
        NAV_IDENT,
        NAV_NAME,
        NAV_CODES,
        NAV_HAS_NAV,
        NAV_HAS_LOCALIZER,
        NAV_HAS_DME,
        NAV_HAS_GLIDE_SLOPE,
        NAV_BACK_COURSE_FLAGS,
        NAV_MAGVAR,
        NAV_RADIAL,
        NAV_RADIAL_ERROR,
        NAV_LOCALIZER,
        NAV_GLIDE_SLOPE,
        NAV_GLIDE_SLOPE_ERROR,
        NAV_CDI,
        NAV_GSI,
        NAV_TOFROM,
        NAV_GS_FLAG,
        NAV_OBS,
        NAV_DME,
        NAV_DMESPEED,
        NAV_VOR_LATLONALT,
        NAV_GS_LATLONALT,
        NAV_DME_LATLONALT,
        NAV_RELATIVE_BEARING_TO_STATION,
        MARKER_BEACON_STATE,
        INNER_MARKER,
        MIDDLE_MARKER,
        OUTER_MARKER,
        INNER_MARKER_LATLONALT,
        MIDDLE_MARKER_LATLONALT,
        OUTER_MARKER_LATLONALT,
        SELECTED_DME,
        REALISM,
        AUTO_COORDINATION,
        UNLIMITED_FUEL,
        REALISM_CRASH_WITH_OTHERS,
        REALISM_CRASH_DETECTION,
        MANUAL_INSTRUMENT_LIGHTS,
        TRUE_AIRSPEED_SELECTED,
        ATC_TYPE,
        ATC_MODEL,
        ATC_HEAVY,
        ATC_ID,
        ATC_AIRLINE,
        ATC_FLIGHT_NUMBER,
        STRUCT_LATLONALT,
        STRUCT_LATLONALTPBH,
        STRUCT_PBH32,
        STRUCT_DAMAGEVISIBLE,
        STRUCT_SURFACE_RELATIVE_VELOCITY,
        STRUCT_WORLDVELOCITY,
        STRUCT_WORLD_ROTATION_VELOCITY,
        STRUCT_BODY_VELOCITY,
        STRUCT_BODY_ROTATION_VELOCITY,
        STRUCT_BODY_ROTATION_ACCELERATION,
        STRUCT_WORLD_ACCELERATION,
        STRUCT_ENGINE_POSITION,
        STRUCT_AMBIENT_WIND,
        STRUCT_REALISM_VARS,
        STRUC_HEADING_HOLD_PID_CONSTS,
        STRUC_AIRSPEED_HOLD_PID_CONSTS,
        STRUCT_EYEPOINT_DYNAMIC_ANGLE,
        STRUCT_EYEPOINT_DYNAMIC_OFFSET,
        PITOT_HEAT,
        PITOT_ICE_PCT,
        SMOKE_ENABLE,
        SMOKESYSTEM_AVAILABLE,
        G_FORCE,
        SEMIBODY_LOADFACTOR_X,
        SEMIBODY_LOADFACTOR_Y,
        SEMIBODY_LOADFACTOR_Z,
        SEMIBODY_LOADFACTOR_YDOT,
        MAX_G_FORCE,
        MIN_G_FORCE,
        SUCTION_PRESSURE,
        RAD_INS_SWITCH,
        TYPICAL_DESCENT_RATE,
        VISUAL_MODEL_RADIUS,
        SIMULATED_RADIUS,
        IS_USER_SIM,
        CONTROLLABLE,
        HEADING_INDICATOR,
        TITLE,
        CATEGORY,
        SIM_DISABLED,
        PROP_DEICE_SWITCH,
        STRUCTURAL_DEICE_SWITCH,
        STRUCTURAL_ICE_PCT,
        ARTIFICIAL_GROUND_ELEVATION,
        SURFACE_INFO_VALID,
        SURFACE_TYPE,
        SURFACE_CONDITION,
        PUSHBACK_STATE,
        PUSHBACK_ANGLE,
        PUSHBACK_CONTACTX,
        PUSHBACK_CONTACTY,
        PUSHBACK_CONTACTZ,
        PUSHBACK_WAIT,
        HSI_CDI_NEEDLE,
        HSI_GSI_NEEDLE,
        HSI_CDI_NEEDLE_VALID,
        HSI_GSI_NEEDLE_VALID,
        HSI_TF_FLAGS,
        HSI_BEARING,
        HSI_BEARING_VALID,
        HSI_HAS_LOCALIZER,
        HSI_SPEED,
        HSI_DISTANCE,
        HSI_STATION_IDENT,
        IS_SLEW_ACTIVE,
        IS_SLEW_ALLOWED,
        ATC_SUGGESTED_MIN_RWY_TAKEOFF,
        ATC_SUGGESTED_MIN_RWY_LANDING,
        YAW_STRING_ANGLE,
        YAW_STRING_PCT_EXTENDED,
        INDUCTOR_COMPASS_PERCENT_DEVIATION,
        INDUCTOR_COMPASS_HEADING_REF,
        ANEMOMETER_PCT_RPM,
        GPS_POSITION_LAT,
        GPS_POSITION_LON,
        GPS_POSITION_ALT,
        GPS_MAGVAR,
        GPS_IS_ACTIVE_FLIGHT_PLAN,
        GPS_IS_ACTIVE_WAY_POINT,
        GPS_IS_ARRIVED,
        GPS_IS_DIRECTTO_FLIGHTPLAN,
        GPS_GROUND_SPEED,
        GPS_GROUND_TRUE_HEADING,
        GPS_GROUND_MAGNETIC_TRACK,
        GPS_GROUND_TRUE_TRACK,
        GPS_ETE,
        GPS_ETA,
        GPS_WP_DISTANCE,
        GPS_WP_BEARING,
        GPS_WP_TRUE_BEARING,
        GPS_WP_CROSS_TRK,
        GPS_WP_DESIRED_TRACK,
        GPS_WP_TRUE_REQ_HDG,
        GPS_WP_VERTICAL_SPEED,
        GPS_WP_TRACK_ANGLE_ERROR,
        GPS_WP_NEXT_ID,
        GPS_WP_NEXT_LAT,
        GPS_WP_NEXT_LON,
        GPS_WP_NEXT_ALT,
        GPS_WP_PREV_VALID,
        GPS_WP_PREV_ID,
        GPS_WP_PREV_LAT,
        GPS_WP_PREV_LON,
        GPS_WP_PREV_ALT,
        GPS_WP_ETE,
        GPS_WP_ETA,
        GPS_COURSE_TO_STEER,
        GPS_FLIGHT_PLAN_WP_INDEX,
        GPS_FLIGHT_PLAN_WP_COUNT,
        GPS_IS_ACTIVE_WP_LOCKED,
        GPS_IS_APPROACH_LOADED,
        GPS_IS_APPROACH_ACTIVE,
        GPS_APPROACH_MODE,
        GPS_APPROACH_WP_TYPE,
        GPS_APPROACH_IS_WP_RUNWAY,
        GPS_APPROACH_SEGMENT_TYPE,
        GPS_APPROACH_AIRPORT_ID,
        GPS_APPROACH_APPROACH_INDEX,
        GPS_APPROACH_APPROACH_ID,
        GPS_APPROACH_APPROACH_TYPE,
        GPS_APPROACH_TRANSITION_INDEX,
        GPS_APPROACH_TRANSITION_ID,
        GPS_APPROACH_IS_FINAL,
        GPS_APPROACH_IS_MISSED,
        GPS_APPROACH_TIMEZONE_DEVIATION,
        GPS_APPROACH_WP_INDEX,
        GPS_APPROACH_WP_COUNT,
        GPS_TARGET_DISTANCE,
        GPS_TARGET_ALTITUDE,
        USER_INPUT_ENABLED,
        ROTOR_BRAKE_HANDLE_POS,
        ROTOR_BRAKE_ACTIVE,
        ROTOR_CLUTCH_SWITCH_POS,
        ROTOR_CLUTCH_ACTIVE,
        ROTOR_TEMPERATURE,
        ROTOR_CHIP_DETECTED,
        ROTOR_GOV_SWITCH_POS,
        ROTOR_GOV_ACTIVE,
        ROTOR_LATERAL_TRIM_PCT,
        ROTOR_RPM_PCT,
        ROTOR_ROTATION_ANGLE,
        COLLECTIVE_POSITION,
        DISK_PITCH_ANGLE,
        DISK_BANK_ANGLE,
        DISK_PITCH_PCT,
        DISK_BANK_PCT,
        DISK_CONING_PCT,
        GEAR_DAMAGE_BY_SPEED,
        GEAR_SPEED_EXCEEDED,
        FLAP_DAMAGE_BY_SPEED,
        FLAP_SPEED_EXCEEDED,
        ESTIMATED_CRUISE_SPEED,
        ESTIMATED_FUEL_FLOW,
        EYEPOINT_POSITION,
        NAV_VOR_LLAF64,
        NAV_GS_LLAF64,
        NAV_RAW_GLIDE_SLOPE,
        WINDSHIELD_RAIN_EFFECT_AVAILABLE,
        STATIC_CG_TO_GROUND,
        STATIC_PITCH,
        CRASH_SEQUENCE,
        CRASH_FLAG,
        APPLY_HEAT_TO_SYSTEMS,
        TOW_RELEASE_HANDLE,
        TOW_CONNECTION,
        APU_PCT_RPM,
        APU_PCT_STARTER,
        APU_VOLTS,
        APU_GENERATOR_SWITCH,
        APU_GENERATOR_ACTIVE,
        APU_ON_FIRE_DETECTED,
        PRESSURIZATION_CABIN_ALTITUDE,
        PRESSURIZATION_CABIN_ALTITUDE_GOAL,
        PRESSURIZATION_CABIN_ALTITUDE_RATE,
        PRESSURIZATION_PRESSURE_DIFFERENTIAL,
        PRESSURIZATION_DUMP_SWITCH,
        FIRE_BOTTLE_SWITCH,
        FIRE_BOTTLE_DISCHARGED,
        CABIN_NO_SMOKING_ALERT_SWITCH,
        CABIN_SEATBELTS_ALERT_SWITCH,
        GPWS_WARNING,
        GPWS_SYSTEM_ACTIVE,
        IS_LATITUDE_LONGITUDE_FREEZE_ON,
        IS_ALTITUDE_FREEZE_ON,
        IS_ATTITUDE_FREEZE_ON,
        NUM_SLING_CABLES,
        SLING_OBJECT_ATTACHED,
        SLING_CABLE_BROKEN,
        SLING_CABLE_EXTENDED_LENGTH,
        SLING_ACTIVE_PAYLOAD_STATION,
        SLING_HOIST_PERCENT_DEPLOYED,
        SLING_HOIST_SWITCH,
        SLING_HOOK_IN_PICKUP_MODE,
        IS_ATTACHED_TO_SLING,
        CABLE_CAUGHT_BY_TAILHOOK,
        EXTERNAL_SYSTEM_VALUE,
        ANNUNCIATOR_SWITCH,
        AUTOBRAKES_ACTIVE,
        REJECTED_TAKEOFF_BRAKES_ACTIVE,
        SHUTOFF_VALVE_PULLED,
        LIGHT_POTENTIOMETER,
        FAKE_AC_LWR,
        FAKE_AC_UPR,
        FAKE_AC_TRIM_L,
        FAKE_AC_TRIM_R,
        FAKE_WINDOW_HEAT_L,
        FAKE_WINDOW_HEAT_R,
        FAKE_BUS_TIE,
        FAKE_EXT_PWR,
        FAKE_GEN_CONT,
        FAKE_UTIL_PWR_L,
        FAKE_UTIL_PWR_R,
        FAKE_CRT_TANK_PUMP_L,
        FAKE_CRT_TANK_PUMP_R,
        FAKE_FUEL_MAIN_AFT,
        FAKE_FUEL_MAIN_FWD,
        FAKE_FUEL_OVRD_AFT,
        FAKE_FUEL_OVRD_FWD,
        FAKE_STAB_TANK_PUMP_L,
        FAKE_STAB_TANK_PUMP_R,
        FAKE_HYD_PUMP_SWITCH,
        FAKE_O2_YD_LOWER,
        FAKE_O2_YD_UPPER,
        FAKE_APU_BLEED,
        FAKE_BLEED,
        FAKE_ISOLATION_VALVE_L,
        FAKE_ISOLATION_VALVE_R,
        FAKE_AC_FLT_DECK,
        FAKE_AC_PASS_TEMP,
        FAKE_STANDBY_POWER,
        FAKE_DEMAND_PUMP_SEL,
        FAKE_IRS_C,
        FAKE_IRS_L,
        FAKE_IRS_R,
        FAKE_ANTI_ICE_NACELLE,
        FAKE_ANTI_ICE_WING,
        FAKE_OUTFLOW_VALVES,
        FAKE_XFEED,
        FAKE_EEC,
        FAKE_PACK,
        FAKE_EMERG_LIGHTS,
        FAKE_TRIM_STAB,
        FAKE_CARGO_ARM_AFT,
        FAKE_XPNDR,
        FAKE_IDENT,
        FAKE_NO_SMOKING,
        FAKE_SEATBELTS,
        FAKE_CARGO_TEMP,
        FAKE_EMERGENCY_LIGHT,
        AUTOPILOT_DISENGAGED,
        FAKE_APU_GEN_SWITCH,
        BREAKER_AVNFAN,
        BREAKER_AUTOPILOT,
        BREAKER_GPS,
        BREAKER_NAVCOM1,
        BREAKER_NAVCOM2,
        BREAKER_NAVCOM3,
        BREAKER_ADF,
        BREAKER_XPNDR,
        BREAKER_FLAP,
        BREAKER_INST,
        BREAKER_AVNBUS1,
        BREAKER_AVNBUS2,
        BREAKER_TURNCOORD,
        BREAKER_INSTLTS,
        BREAKER_ALTFLD,
        BREAKER_WARN,
        BREAKER_LTS_PWR,
        PILOT_TRANSMITTER_TYPE,
        COPILOT_TRANSMITTER_TYPE,
        PILOT_TRANSMITTING,
        COPILOT_TRANSMITTING,
        SPEAKER_ACTIVE,
        INTERCOM_SYSTEM_ACTIVE,
        AUDIO_PANEL_VOLUME,
        MARKER_BEACON_SENSITIVITY_HIGH,
        MARKER_BEACON_TEST_MUTE,
        INTERCOM_MODE,
        COM_RECEIVE,
        AUTOPILOT_ALTITUDE_ARM,
        COM_VOLUME,
        NAV_VOLUME,
        ATC_CLEARED_IFR,
        ATC_IFR_FP_TO_REQUEST,
        ATC_RUNWAY_SELECTED,
        ATC_TAXIPATH_DISTANCE,
        ATC_RUNWAY_START_DISTANCE,
        ATC_RUNWAY_END_DISTANCE,
        ATC_RUNWAY_DISTANCE,
        ATC_RUNWAY_RELATIVE_POSITION_X,
        ATC_RUNWAY_RELATIVE_POSITION_Y,
        ATC_RUNWAY_RELATIVE_POSITION_Z,
        ATC_RUNWAY_TDPOINT_RELATIVE_POSITION_X,
        ATC_RUNWAY_TDPOINT_RELATIVE_POSITION_Y,
        ATC_RUNWAY_TDPOINT_RELATIVE_POSITION_Z,
        ATC_RUNWAY_HEADING_DEGREES_TRUE,
        ATC_RUNWAY_LENGTH,
        ATC_RUNWAY_WIDTH,
        ATC_RUNWAY_AIRPORT_NAME,
        SLOPE_TO_ATC_RUNWAY,
        ATC_CLEARED_TAKEOFF,
        ATC_CLEARED_LANDING,
        ATC_CLEARED_TAXI,
        ON_ANY_RUNWAY,
        ATC_FLIGHTPLAN_DIFF_HEADING,
        ATC_FLIGHTPLAN_DIFF_ALT,
        ATC_FLIGHTPLAN_DIFF_DISTANCE,
        ATC_PREVIOUS_WAYPOINT_ALTITUDE,
        ATC_CURRENT_WAYPOINT_ALTITUDE,
        ASSISTANCE_LANDING_ENABLED,
        COM1_STORED_FREQUENCY,
        COM2_STORED_FREQUENCY,
        COM3_STORED_FREQUENCY,
        RUDDER_TRIM_DISABLED,
        AILERON_TRIM_DISABLED,
        ELEVATOR_TRIM_DISABLED,
        PLANE_TOUCHDOWN_LATITUDE,
        PLANE_TOUCHDOWN_LONGITUDE,
        PLANE_TOUCHDOWN_PITCH_DEGREES,
        PLANE_TOUCHDOWN_BANK_DEGREES,
        PLANE_TOUCHDOWN_HEADING_DEGREES_MAGNETIC,
        PLANE_TOUCHDOWN_HEADING_DEGREES_TRUE,
        PLANE_TOUCHDOWN_NORMAL_VELOCITY,
        TURB_ENG_IGNITION_SWITCH_EX1,
        TURB_ENG_IS_IGNITING,
        PLANE_IN_PARKING_STATE,
        ELT_ACTIVATED,
        RECIP_ENG_ENGINE_MASTER_SWITCH,
        RECIP_ENG_GLOW_PLUG_ACTIVE,
        LIGHT_GLARESHIELD,
        LIGHT_PEDESTRAL,
        LIGHT_GLARESHIELD_ON,
        LIGHT_PEDESTRAL_ON,
        CIRCUIT_NAVCOM1_ON,
        CIRCUIT_NAVCOM2_ON,
        CIRCUIT_NAVCOM3_ON,
        AIRSPEED_TRUE_RAW,
        GENERAL_ENG_FUEL_PUMP_SWITCH_EX1,
        FUEL_TRANSFER_PUMP_ON,
        IS_ANY_INTERIOR_LIGHT_ON,
        GPS_FLIGHTPLAN_TOTAL_DISTANCE,
        CIRCUIT_ON,
        CIRCUIT_SWITCH_ON,
        BUS_LOOKUP_INDEX,
        BUS_CONNECTION_ON,
        BATTERY_CONNECTION_ON,
        ALTERNATOR_CONNECTION_ON,
        CIRCUIT_CONNECTION_ON,
        BUS_BREAKER_PULLED,
        BATTERY_BREAKER_PULLED,
        ALTERNATOR_BREAKER_PULLED,
        CIRCUIT_BREAKER_PULLED,
        CAMERA_STATE,
        CAMERA_SUBSTATE,
        SMART_CAMERA_ACTIVE,
        CAMERA_REQUEST_ACTION,
        ADF_VOLUME,
        BLEED_AIR_APU,
        BLEED_AIR_ENGINE,
        APU_BLEED_TO_ENGINE,
        EXTERNAL_POWER_CONNECTION_ON,
        EXTERNAL_POWER_BREAKER_PULLED,
        EXTERNAL_POWER_AVAILABLE,
        EXTERNAL_POWER_ON,
    }

    public enum EVENT_IDS
    {
        COM_RADIO_WHOLE_DEC,
        COM_RADIO_WHOLE_INC,
        COM_RADIO_FRACT_DEC,
        COM_RADIO_FRACT_INC,
        COM_STBY_RADIO_SWAP,
        COM2_RADIO_WHOLE_INC,
        COM2_RADIO_WHOLE_DEC,
        COM2_RADIO_FRACT_INC,
        COM2_RADIO_FRACT_DEC,
        COM2_RADIO_SWAP,
        COM_STBY_RADIO_SET_HZ
    };

    public enum GROUPS
    {
        GROUP1,
        MAX
    }

    public class SimVar
    {
        public SimVars SimVariable { get; private set; }

        public Units Units { get; private set; }
        
        public int? Index { get; private set; }

        public SimVar(SimVars variable, Units unit, int? index)
        {
            SimVariable = variable;
            Units = unit;
            Index = index;
        }

        public string SimConnectVariable
        {
            get
            {
                var str = SimVariable.ToString().Replace('_', ' ');

                if (Index.HasValue)
                {
                    str += ":" + Index.Value;
                }

                return str;
            }
        }

        public string SimConnectUnit
        {
            get
            {
                return Units.ToString()
                    .Replace("___", "-")
                    .Replace("__", "/")
                    .Replace("_", " ");
            }
        }
    }
}
