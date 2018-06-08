//TODO
//Globale Konstante für Software Endlage anpassen
//Referenzstatus senden
#include <kissStepper.h>
#include <Servo.h>
#include <Bounce2.h>
//#define UNO_TEST

// ****************************************************************************************************
// Einstellungen
// ****************************************************************************************************
#ifndef UNO_TEST
const uint8_t J1_STEP_PIN = 22;
const uint8_t J1_DIR_PIN = 23;
const uint8_t J2_STEP_PIN = 26;
const uint8_t J2_DIR_PIN = 27;
const uint8_t J3_STEP_PIN = 30;
const uint8_t J3_DIR_PIN = 31;
const uint8_t J4_STEP_PIN = 34;
const uint8_t J4_DIR_PIN = 35;
const uint8_t J5_STEP_PIN = 38;
const uint8_t J5_DIR_PIN = 39;
const uint8_t J6_STEP_PIN = 42;
const uint8_t J6_DIR_PIN = 43;
const driveMode_t J1_MODE = FULL_STEP;
const driveMode_t J2_MODE = HALF_STEP;
const driveMode_t J3_MODE = HALF_STEP;
const driveMode_t J4_MODE = HALF_STEP;
const driveMode_t J5_MODE = MICROSTEP_4;
const driveMode_t J6_MODE = HALF_STEP;

const uint8_t J1_LIMIT_SWITCH_PIN = 14;
const uint8_t J2_LIMIT_SWITCH_PIN = 15;
const uint8_t J3_LIMIT_SWITCH_PIN = 16;
const uint8_t J4_LIMIT_SWITCH_PIN = 17;
const uint8_t J5_LIMIT_SWITCH_PIN = 18;
const uint8_t J6_LIMIT_SWITCH_PIN = 19;

const uint8_t SERVO1_PIN = 11;
const uint8_t SERVO2_PIN = 12;
const uint8_t SERVO3_PIN = 13;

const uint8_t EMERGENCY_STOP_PIN = 4;

const int32_t J1_POS_STEP_LIMIT = 2000000;
const int32_t J1_NEG_STEP_LIMIT = -2000000;
const int32_t J2_POS_STEP_LIMIT = 2000000;
const int32_t J2_NEG_STEP_LIMIT = -2000000;
const int32_t J3_POS_STEP_LIMIT = 2000000;
const int32_t J3_NEG_STEP_LIMIT = -2000000;
const int32_t J4_POS_STEP_LIMIT = 2000000;
const int32_t J4_NEG_STEP_LIMIT = -2000000;
const int32_t J5_POS_STEP_LIMIT = 2000000;
const int32_t J5_NEG_STEP_LIMIT = -2000000;
const int32_t J6_POS_STEP_LIMIT = 2000000;
const int32_t J6_NEG_STEP_LIMIT = -2000000;
#else
const uint8_t J1_STEP_PIN = 2;
const uint8_t J1_DIR_PIN = 1;
const uint8_t J2_STEP_PIN = 3;
const uint8_t J2_DIR_PIN = 4;
const uint8_t J3_STEP_PIN = 5;
const uint8_t J3_DIR_PIN = 6;
const uint8_t J4_STEP_PIN = 7;
const uint8_t J4_DIR_PIN = 8;
const uint8_t J5_STEP_PIN = 9;
const uint8_t J5_DIR_PIN = 10;
const uint8_t J6_STEP_PIN = 11;
const uint8_t J6_DIR_PIN = 12;
const driveMode_t J1_MODE = FULL_STEP;
const driveMode_t J2_MODE = HALF_STEP;
const driveMode_t J3_MODE = HALF_STEP;
const driveMode_t J4_MODE = HALF_STEP;
const driveMode_t J5_MODE = MICROSTEP_4;
const driveMode_t J6_MODE = HALF_STEP;

const uint8_t J1_LIMIT_SWITCH_PIN = 13;
const uint8_t J2_LIMIT_SWITCH_PIN = 14;
const uint8_t J3_LIMIT_SWITCH_PIN = 15;
const uint8_t J4_LIMIT_SWITCH_PIN = 16;
const uint8_t J5_LIMIT_SWITCH_PIN = 17;
const uint8_t J6_LIMIT_SWITCH_PIN = 18;

const uint8_t EMERGENCY_STOP_PIN = 19;

const int32_t J1_POS_STEP_LIMIT = 2000000;
const int32_t J1_NEG_STEP_LIMIT = -2000000;
const int32_t J2_POS_STEP_LIMIT = 2000000;
const int32_t J2_NEG_STEP_LIMIT = -2000000;
const int32_t J3_POS_STEP_LIMIT = 2000000;
const int32_t J3_NEG_STEP_LIMIT = -2000000;
const int32_t J4_POS_STEP_LIMIT = 2000000;
const int32_t J4_NEG_STEP_LIMIT = -2000000;
const int32_t J5_POS_STEP_LIMIT = 2000000;
const int32_t J5_NEG_STEP_LIMIT = -2000000;
const int32_t J6_POS_STEP_LIMIT = 2000000;
const int32_t J6_NEG_STEP_LIMIT = -2000000;
#endif // UNO_TEST

// ****************************************************************************************************
// Globale Variablen und Objekte
// ****************************************************************************************************
// Kommunikation
struct structMsgData
{
	String func;
	uint16_t cnt;
	int32_t parSet[6][8];
};
structMsgData MsgData;

// Motoren
kissStepper stepper[6] = {
	kissStepper(J1_MODE, J1_DIR_PIN, J1_STEP_PIN),
	kissStepper(J2_MODE, J2_DIR_PIN, J2_STEP_PIN),
	kissStepper(J3_MODE, J3_DIR_PIN, J3_STEP_PIN),
	kissStepper(J4_MODE, J4_DIR_PIN, J4_STEP_PIN),
	kissStepper(J5_MODE, J5_DIR_PIN, J5_STEP_PIN),
	kissStepper(J6_MODE, J6_DIR_PIN, J6_STEP_PIN)
};
boolean refOkay[6] = { false, false, false, false, false, false };
uint16_t stopAcc[6];

// Servos
Servo servos[3] = {
	Servo(),
	Servo(),
	Servo()
};

// Endschalter
const uint8_t LIMITSWITCH_PINS[6] = { 
	J1_LIMIT_SWITCH_PIN, 
	J2_LIMIT_SWITCH_PIN, 
	J3_LIMIT_SWITCH_PIN, 
	J4_LIMIT_SWITCH_PIN, 
	J5_LIMIT_SWITCH_PIN,
	J6_LIMIT_SWITCH_PIN
};
Bounce limitswitches[6];
// Not-Halt
Bounce emergencystop;

// ****************************************************************************************************
// SETUP
// ****************************************************************************************************
void setup(void) {
	Serial.begin(2000000);

	// Enschalter
	for (uint8_t i = 0; i < 6; i++) {
		limitswitches[i].attach(LIMITSWITCH_PINS[i], INPUT_PULLUP);
		limitswitches[i].interval(3);
	}
	emergencystop.attach(EMERGENCY_STOP_PIN, INPUT_PULLUP);
	// Nothalt
	emergencystop.interval(3);

	// Schrittmotoren initialisieren
	for (uint8_t i = 0; i < 6; i++) stepper[i].begin();
	stepper[0].forwardLimit = J1_POS_STEP_LIMIT;
	stepper[0].reverseLimit = J1_NEG_STEP_LIMIT;
	stepper[1].forwardLimit = J2_POS_STEP_LIMIT;
	stepper[1].reverseLimit = J2_NEG_STEP_LIMIT;
	stepper[2].forwardLimit = J3_POS_STEP_LIMIT;
	stepper[2].reverseLimit = J3_NEG_STEP_LIMIT;
	stepper[3].forwardLimit = J4_POS_STEP_LIMIT;
	stepper[3].reverseLimit = J4_NEG_STEP_LIMIT;
	stepper[4].forwardLimit = J5_POS_STEP_LIMIT;
	stepper[4].reverseLimit = J5_NEG_STEP_LIMIT;
	stepper[5].forwardLimit = J6_POS_STEP_LIMIT;
	stepper[5].reverseLimit = J6_NEG_STEP_LIMIT;

	// Servos initialisieren
#ifndef UNO_TEST
	servos[0].attach(SERVO1_PIN);
	servos[1].attach(SERVO2_PIN);
	servos[2].attach(SERVO3_PIN);
#endif // UNO_TEST	
	// Init
	sendRES();
}

// ****************************************************************************************************
// LOOP
// ****************************************************************************************************
void loop(void)
{
	// Endschalter einlesen
	updateLimitSwitches();
	for (int i = 0; i < 6; i++) {
		if (limitswitches[i].rose() || limitswitches[i].fell()) sendLSS();
	}

	// Nothalt prüfen
	emergencystop.update();
	if (emergencystop.rose() || emergencystop.fell()) {
		sendRES();
		sendESS();
		if (!emergencystop.read()) for (uint8_t i = 0; i < 6; i++) refOkay[i] = false;
	}	

	// Check Serial Data
	recvMsg();
}


// ****************************************************************************************************
// ROBOTERSTEUERUNG
// ****************************************************************************************************
// ----------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------

boolean checkRoboStop() {
	if (Serial.available() > 0) if (Serial.read() == '!') {
		roboStop();
		return true;
	}
	return false;
}

// ----------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------
boolean checkEstop() {
	// Nothalt prüfen
	emergencystop.update();
	if (emergencystop.fell()) {
		roboFastStop();
		sendRES();
		sendESS();
		for (uint8_t i = 0; i < 6; i++) refOkay[i] = false;
		return true;
	}
	return false;
}

// ----------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------
void updateLimitSwitches() {
	for (uint8_t i = 0; i < 6; i++) {
		limitswitches[i].update();
	}
}

// ----------------------------------------------------------------------------------------------------
// normale Bewegung
// ----------------------------------------------------------------------------------------------------
void roboMOV() {
	if (MsgData.cnt > 0) {
		for (uint8_t i = 0; i < MsgData.cnt; i++) {
			uint8_t nr = MsgData.parSet[i][0];
			int32_t target = MsgData.parSet[i][1];
			uint16_t speed = MsgData.parSet[i][2];
			uint16_t acc = MsgData.parSet[i][3];
			stopAcc[nr - 1] = MsgData.parSet[i][4];

			// Referenz prüfen
			if (!refOkay[nr - 1]) {
				sendERR(3);
				roboFastStop();
				return;
			}

			// Daten prüfen
			if (nr > 6 || nr < 1 || speed == 0 || acc == 0 || stopAcc[nr - 1] == 0) {
				sendERR(2);
				roboFastStop();
				return;
			}
			// Fahrt initieren
			roboInitMove(stepper[nr - 1], target, speed, acc);
		}
		sendACK(); // Telegramm bestätigen
		// Achsen verfahren
		while (roboWork()) {
			checkEstop();
			checkRoboStop();
		}
	}
	// Fertig
	sendPOS();
	sendFIN();
}

// ----------------------------------------------------------------------------------------------------
// Referenzfahrt
// ----------------------------------------------------------------------------------------------------
void roboREF() {
#ifdef UNO_TEST
	sendACK();
	// Referenzfahrt abschließen
	for (uint8_t i = 0; i < MsgData.cnt; i++) {
		uint8_t nr = MsgData.parSet[i][0];
		stepper[nr - 1].setPos(0);
		refOkay[nr - 1] = true;
	}
	sendPOS();
	sendFIN();
	return;
#endif
	boolean stopRef = false;
// Schnell auf Endschalter fahren
	for (uint8_t i = 0; i < MsgData.cnt; i++) {
		uint8_t nr = MsgData.parSet[i][0];
		boolean dir = MsgData.parSet[i][1] == 0 ? false : true;
		uint16_t speedFast = MsgData.parSet[i][2];
		uint16_t speedSlow = MsgData.parSet[i][3];
		uint16_t acc = MsgData.parSet[i][4];
		uint16_t maxStepsBack = MsgData.parSet[i][5];
		stopAcc[nr - 1] = MsgData.parSet[i][6];
		// Daten prüfen
		if (nr > 6 || nr < 1 || speedFast == 0 || speedSlow == 0 || acc == 0 || maxStepsBack == 0 || stopAcc[nr - 1] == 0) {
			roboFastStop();
			sendERR(2);
			return; // Referenzfahrt abbrechen
		}
		// Fahrt initieren
		roboInitMove(stepper[nr - 1], dir ? stepper[nr - 1].forwardLimit : stepper[nr - 1].reverseLimit, speedFast, acc);
	}	
	sendACK(); // Telegramm bestätigen
	// Endschalter schon belegt? => dann gleich "stoppen"
	updateLimitSwitches();
	for (uint8_t i = 0; i < 6; i++) if (limitswitches[i].read()) stepper[i].stop();
	// Achsen verfahren...
	while (roboWork()) {
		if (checkEstop()) return;	//bei Nothalt Referenzfahrt abbrechen
		stopRef |= checkRoboStop();
		updateLimitSwitches();		
		for (uint8_t i = 0; i < 6; i++) if (limitswitches[i].rose()) stepper[i].stop();
	}
	if (stopRef) return; //Referenzfahrt abbrechen

// 500ms Warten
	_delay_ms(500);

// vom Endschalter runterfahren
	for (uint8_t i = 0; i < MsgData.cnt; i++) {
		uint8_t nr = MsgData.parSet[i][0];
		boolean dir = MsgData.parSet[i][1] == 0 ? false : true;
		uint16_t speedFast = MsgData.parSet[i][2];
		uint16_t acc = MsgData.parSet[i][4];
		uint16_t maxStepsBack = MsgData.parSet[i][5];
		// Fahrt initieren
		roboInitMove(stepper[nr - 1], !dir ? stepper[nr - 1].getPos() + maxStepsBack : stepper[nr - 1].getPos() - maxStepsBack, speedFast, acc);
	}
	// Endschalter schon frei? => dann gleich "stoppen"
	updateLimitSwitches();
	for (uint8_t i = 0; i < 6; i++) if (!limitswitches[i].read()) stepper[i].stop();
	// Achsen verfahren...
	while (roboWork()) {
		if (checkEstop()) return;	//bei Nothalt Referenzfahrt abbrechen
		stopRef |= checkRoboStop();
		updateLimitSwitches();
		for (uint8_t i = 0; i < 6; i++) if (limitswitches[i].fell()) stepper[i].decelerate();
	}
	if (stopRef) return; //Referenzfahrt abbrechen
	//Wurden Endschalter wirklich verlassen?
	for (uint8_t i = 0; i < MsgData.cnt; i++) {
		uint8_t nr = MsgData.parSet[i][0];
		if (limitswitches[nr - 1].read()) {
			roboFastStop();
			sendERR(4);
			return; // Referenzfahrt abbrechen
		}
	}
// 250ms Warten
	_delay_ms(250);

// Langsam auf Endschalter fahren
	for (uint8_t i = 0; i < MsgData.cnt; i++) {
		uint8_t nr = MsgData.parSet[i][0];
		boolean dir = MsgData.parSet[i][1] == 0 ? false : true;
		uint16_t speedSlow = MsgData.parSet[i][3];
		uint16_t acc = MsgData.parSet[i][4];
		// Fahrt initieren
		roboInitMove(stepper[nr - 1], dir ? stepper[nr - 1].forwardLimit : stepper[nr - 1].reverseLimit, speedSlow, acc);
	}
	// Endschalter schon belegt? => dann gleich "stoppen"
	updateLimitSwitches();
	for (uint8_t i = 0; i < 6; i++) if (limitswitches[i].read()) stepper[i].stop();
	// Achsen verfahren...
	while (roboWork()) {
		if (checkEstop()) return;	//bei Nothalt Referenzfahrt abbrechen
		stopRef |= checkRoboStop();
		updateLimitSwitches();
		for (uint8_t i = 0; i < 6; i++) if (limitswitches[i].rose()) stepper[i].stop();
	}
	if (stopRef) return; //Referenzfahrt abbrechen

	// Referenzfahrt abschließen
	for (uint8_t i = 0; i < MsgData.cnt; i++) {
		uint8_t nr = MsgData.parSet[i][0];		
		stepper[nr - 1].setPos(0);
		refOkay[nr - 1] = true;
	}
	sendPOS();
	sendESS();
	sendFIN();
}

// ----------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------
void roboSRV() {
	if (MsgData.parSet[0][0] > 3 || MsgData.parSet[0][0] < 1) {
		sendERR(2);
		return;
	}
#ifndef UNO_TEST
	servos[MsgData.parSet[0][0] - 1].write(MsgData.parSet[0][1]);
#endif
	sendACK();
	sendFIN();
}

// ----------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------
void roboWAI() {
	if (MsgData.parSet[0][0] <= 0) {
		sendERR(2);
		return;
	}
	sendACK();
	//warten
	delay(MsgData.parSet[0][0]);
	sendFIN();
}

// ----------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------
void roboInitMove(kissStepper &mot, int32_t target, uint16_t speed, uint16_t acc)
{
	mot.setAccel(acc);
	mot.setMaxSpeed(speed);
	mot.moveTo(target);
}

// ----------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------
boolean roboWork()
{
	boolean working = false;
	for (uint8_t i = 0; i < 6; i++) {
		working |= stepper[i].work();
	}
	return working;
}

// ----------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------
void roboStop() {
	for (uint8_t i = 0; i < 6; i++) {
		stepper[i].setAccel(stopAcc[i]);
		stepper[i].decelerate();
	}
}

// ----------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------
void roboFastStop() {
	for (uint8_t i = 0; i < 6; i++) {
		stepper[i].stop();
	}
}

// ****************************************************************************************************
// KOMMUNIKATION
// ****************************************************************************************************
void recvMsg() {
	// wait for serial message
	static String Msg = "";
	static boolean MsgIn = false;

	while (Serial.available() > 0)
	{
		char c = Serial.read();
		if (c == '<') {
			MsgIn = true;
			Msg = "";
		}
		else if (c == '>')
		{
			MsgIn = false;

			//parse Msg
			parseMsg(Msg, MsgData);
			Msg = "";

			//CON
			//***************
			if (MsgData.func == "con") rcvCON();
			//MOV
			//***************
			else if (MsgData.func == "mov") roboMOV();
			//REF
			//***************
			else if (MsgData.func == "ref") roboREF();
			//SRV
			//***************
			else if (MsgData.func == "srv") roboSRV();
			//WAI
			//***************
			else if (MsgData.func == "wai") roboWAI();
			//NO FUNCTION
			//***************
			else sendERR(1);
		}
		else if (MsgIn) Msg += c;
	}
}

// ----------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------
void sendACK() {
	Serial.print(F("ack"));
	sendNewLine();
}

// ----------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------
void sendFIN() {
	Serial.print(F("fin"));
	sendNewLine();
}

// ----------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------
void sendERR(uint8_t errnum) {
	Serial.print(String(F("err#")) + String(errnum));
	sendNewLine();
}

// ----------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------
void sendPOS() {
	Serial.print(F("pos"));
	for (uint8_t i = 0; i < 6; i++) {
		Serial.print(String (F("#")) + String(i+1) + String(refOkay[i] ? F(",1,") : F(",0,")) + String(stepper[i].getPos()));
	}
	sendNewLine();
}

// ----------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------
void sendESS() {
	Serial.print(String(F("ess#")) + String(emergencystop.read() ? F("0") : F("1")));
	sendNewLine();
}

// ----------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------
void sendLSS() {
	Serial.print(F("lss"));
	for (uint8_t i = 0; i < 6; i++) {
		Serial.print(String(F("#")) + String(i+1) + String(F(",")) + String(limitswitches[i].read() ? F("1") : F("0")));
	}
	sendNewLine();
}

// ----------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------
void sendRES() {
	Serial.print(F("res"));
	sendNewLine();
}

// ----------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------
void sendNewLine() {
	Serial.print(F("\n"));
}

// ----------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------
void rcvCON() {
	sendACK();
	sendESS();
	sendLSS();
	sendPOS();
}

// ----------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------
void parseMsg(String &_msg, struct structMsgData &_msgData)
{
	_msgData.cnt = 0;

	_msg.trim();
	_msg.toLowerCase();
	
	//Länge prüfen
	if (_msg.length() < 3) return;
	//auszuführende Funktion / Aktion
	_msgData.func = _msg.substring(0, 3);
	//Länge prüfen
	if (_msg.length() < 4) return;
	String tmpCommand = _msg.substring(4);
	//Parametersatz splitten
	uint16_t iParSet = 0;
	uint16_t lastParSetIndex = 0;
	while (tmpCommand.indexOf('#', lastParSetIndex) > 0) { //es gibt noch ein '#' Zeichen!
		uint16_t ParSetIndex = tmpCommand.indexOf('#', lastParSetIndex);

		String tmpParSet = tmpCommand.substring(lastParSetIndex, ParSetIndex);
		//Parameter splitten
		uint16_t iPar = 0;
		uint16_t lastParIndex = 0;
		while (tmpParSet.indexOf(',', lastParIndex) > 0) { //es gibt noch ein ',' Zeichen
			uint16_t ParIndex = tmpParSet.indexOf(',', lastParIndex);
			_msgData.parSet[iParSet][iPar] = tmpParSet.substring(lastParIndex, ParIndex).toInt();
			iPar++;
			lastParIndex = ParIndex + 1;
		}
		//letzten Parameter berücksichtigen
		_msgData.parSet[iParSet][iPar] = tmpParSet.substring(lastParIndex).toInt();
		//restliche Parameter mit 0 befüllen
		for (uint16_t i = iPar + 1; i < 8; i++) _msgData.parSet[iParSet][i] = 0;

		iParSet++;
		lastParSetIndex = ParSetIndex + 1;
		tmpParSet = "";
	}

	//letzten Parametersatz berücksichtigen, wenn es einen gibt!
	if (tmpCommand.length() > 0) {
		String tmpParSet = tmpCommand.substring(lastParSetIndex);
		//Split parameter
		uint16_t iPar = 0;
		uint16_t lastParIndex = 0;
		while (tmpParSet.indexOf(',', lastParIndex) > 0) { //es gibt noch ein ',' Zeichen
			uint16_t ParIndex = tmpParSet.indexOf(',', lastParIndex);
			_msgData.parSet[iParSet][iPar] = tmpParSet.substring(lastParIndex, ParIndex).toInt();
			iPar++;
			lastParIndex = ParIndex + 1;
		}
		//letzten Parameter berücksichtigen
		_msgData.parSet[iParSet][iPar] = tmpParSet.substring(lastParIndex).toInt();
		//restliche Parameter mit 0 befüllen
		for (uint16_t i = iPar + 1; i < 8; i++) _msgData.parSet[iParSet][i] = 0;

		iParSet++;
	}
	_msgData.cnt = iParSet;
	tmpCommand = "";
}