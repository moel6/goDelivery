
// typedef enum{waitingFor, scanColorCode, returnPackage, searchBlueSP, searchRedSP, driveClockwise, driveCounterClockwise, turnToDoor, waitForDelivering, deliverPackage, returnToPickupPoint} state;
enum State {waitingFor, emergencyStop, scanColorCode, returnPackage, searchBlueSP, searchRedSP, driveClockwise, driveCounterClockwise, turnToDoor, waitForDelivering, deliverPackage, returnToPickupPoint, makeATurnBack};

// van elk punt kan hij naar returnToPickupPoint
#include "EV3Mailbox.c"
enum State waitingState() //Sub-test check
{
	char msgBufIn[20];  // To contain the incoming message.

	string IncomingMessage; //To contain the string of the incoming message

	openMailboxIn("EV3_INBOX0");
	openMailboxOut("EV3_OUTBOX0");
	readMailboxIn("EV3_INBOX0", msgBufIn);


	if (strcmp(msgBufIn, "") != 0)
	{
		stringFromChars(IncomingMessage,msgBufIn) ; //If c# says start program, robotC program starts
		if(IncomingMessage == "StartProgram")
		{
			//Lift arms up
			motor[motorD] = 15;
			delay(700);
			motor[motorD] = 0;
			//If arms are fully up, continue program*/
			waitUntil(getTouchValue(S4) == true);
			return  scanColorCode;
		}
	}
	else
	{
		motor[motorD] = -10;
		delay(1000);
		motor[motorD] = 0;
		return waitingFor;
	}
}
enum State scanColorCodeState() //Sub-test check
{
	char msgBufIn1[20];  // To contain the incoming message for inbox 1.
	string IncomingMessage1; //To contain the string of the incoming message

	openMailboxIn("EV3_INBOX1");
	readMailboxIn("EV3_INBOX1", msgBufIn1);
	stringFromChars(IncomingMessage1,msgBufIn1) ; //Convert the char to string, put it into IncomingMessage variable.


	drawBmpfile(0, 127, "Big smile"); //Put a smile on the face

	//define code for colorscanning
	while (true)
	{
		int color = getColorName(S2); // de waarde van de kleur
		if(color == 3 && stringFind(IncomingMessage1,"groen") >= 0)// waarde kleur groen
		{
			return searchBlueSP;
		}
		else if (color == 2 && stringFind(IncomingMessage1,"bl") >= 0)
		{
			return  searchBlueSP;
		}
		else if (color == 5 && stringFind(IncomingMessage1,"rood") >= 0)
		{
			return  searchRedSP;
		}
		else if (color == 4 && stringFind(IncomingMessage1,"geel") >= 0)
		{
			return searchRedSP;
		}
		else
		{

			return returnPackage;
		}
	}
}

enum State returnPackageState()
{

	{
		//Playing sound "Uh-oh", color not recognised
		playSoundFile("Uh-oh");
		delay(500);

		//Lifting mechanism goes down again
		motor[motorD] = -10;
		delay(800);
		motor[motorD] = 0;

		//Set status again to waitingFor
		return waitingFor;
	}
}


enum State searchBlueSPState() //Sub-test check
{
	bool blue = false;

	while (blue == false)
	{

		if (getColorName(S3) == 2)
		{
			motor(motorB) = 0;
			motor(motorC) = 0;
			blue = true;
		}
		else if(getColorName(S3) == 1 || getColorName(S3) == 5)
		{

			motor [motorB] = -25;
			motor [motorC] = -25;
			delay (500);
			motor [motorB] = 0;
			motor [motorC] = 10;
			delay(500);

		}
		else
		{
			motor[motorB] = 25;
			motor[motorC] = 25;
		}

	}
	motor [motorB] = 25;
	motor [motorC] = 20;
	delay(500);
	return driveClockwise;
}


enum State driveClockwiseState() //Sub-test check
{
	int targetColor = getColorName(S2);
	bool greenColor = false;
	bool blueColor = false;
	bool checkDone =false;

	while (greenColor == false)
	{
		if (getColorName(S3) == 3) //kleur groen
		{
			motor(motorB) = 0;
			motor(motorC) = 0;
			if (targetColor == 3)
			{
				checkDone = true;
				blueColor = true;
			}
			greenColor = true;
		}

		if(getColorName(S3) == 1 || getColorName(S3) == 7)
		{

			motor[motorC] = 0; // Motor C is run at a 30 power level
			motor[motorB] = 30;
			delay(50);


		}
		else if (getColorName(S3) == 6) // If the Light Sensor reads a value greater than or equal to 50
		{
			motor[motorB] = 0; // Motor B is run at a 30 power level
			motor[motorC] = 30; // Motor C is run at a 0 power level
			delay(50);
		}
	}

	while (blueColor == false)
	{

		if (getColorName(S3) == 2)
		{
			motor(motorB) = 0;
			motor(motorC) = 0;
			checkDone = true;
			blueColor = true;

		}

		if(getColorName(S3) == 1 || getColorName(S3) == 7)
		{

			motor[motorC] = 30; // Motor C is run at a 30 power level
			motor[motorB] = 0;
			delay(50);
		}
		else if (getColorName(S3) == 6) // If the Light Sensor reads a value greater than or equal to 50
		{
			motor[motorB] = 30; // Motor B is run at a 30 power level
			motor[motorC] = 0; // Motor C is run at a 0 power level
			delay(50);
		}
		else
		{
			motor[motorB] = 25;
			motor[motorC] = 20;
		}

	}

	if (checkDone == true)
	{
		return turnToDoor;
	}
	else
	{
		return returnToPickupPoint;
	}
}
enum State searchRedSPState () //Sub-test check
{
	bool red = false;



	while (red == false)
	{
		if (getColorName(S3) == 5)
		{
			motor(motorB) = 0;
			motor(motorC) = 0;
			red = true;
		}
		else if(getColorName(S3) == 1 || getColorName(S3) == 2)
		{
			motor [motorB] = -25;
			motor [motorC] = -25;
			delay (500);
			motor [motorB] = 0;
			motor [motorC] = 10;
			delay (500);
		}
		else
		{
			motor[motorB] = 25;
			motor[motorC] = 25;
		}
	}
	motor [motorB] = 25;
	motor [motorC] = 20;
	delay(500);
	return driveCounterClockwise;
}

enum State driveCounterClockWiseState() //Sub-test check
{
	bool yellowColor = false;
	bool redColor = false;
	bool checkDone =false;

motor[motorC] = 10;
motor[motorB] = 15;
delay(500);

	while (yellowColor == false)
	{
		if (getColorName(S3) == 4)
		{
			motor(motorB) = 0;
			motor(motorC) = 0;
			if (getColorName(S2) == 4)
			{
				checkDone = true;
				redColor = true;
				yellowColor = true;
			}
			else
			{
				yellowColor = true;
			}
		}

		if(getColorName(S3) == 1 || getColorName(S3) == 7)
		{

			motor[motorC] = 0; // Motor C is run at a 30 power level
			motor[motorB] = 30;
			delay(50);
		}
		else if (getColorName(S3) == 6) // If the Light Sensor reads a value greater than or equal to 50
		{
			motor[motorB] = 0; // Motor B is run at a 30 power level
			motor[motorC] = 30; // Motor C is run at a 0 power level
			delay(50);
		}
	}
	while (redColor == false)
	{
		eraseDisplay();

		if (getColorName(S3) == 5)
		{
			motor(motorB) = 0;
			motor(motorC) = 0;
			checkDone = true;
			redColor = true;
		}

		if(getColorName(S3) == 1 || getColorName(S3) == 7)
		{

			motor[motorC] = 0; // Motor C is run at a 30 power level
			motor[motorB] = 30;
			delay(50);


		}
		else if (getColorName(S3) == 6) // If the Light Sensor reads a value greater than or equal to 50
		{
			motor[motorB] = 0; // Motor B is run at a 30 power level
			motor[motorC] = 30; // Motor C is run at a 0 power level
			delay(50);
		}
		else
		{
			motor[motorB] = 25;
			motor[motorC] = 20;
		}

	}

	if (checkDone == true)
	{
		return turnToDoor;
	}
	else
	{
		return returnToPickupPoint;
	}
}

enum State turnToDoorState() //Sub=-test check
{
	int targetColor = getColorName(S2);
	int rotatie;

	if (targetColor == 5 || targetColor == 4) //Als de te bezorgen kleur rood of geel is/ draai rechtsom
	{
		rotatie = 1;
	}
	else if(targetColor == 3 || targetColor == 2) //Als de te bezorgen kleur blauw of groen is/ draai linksom
	{
		rotatie = 0;
	}

	if (rotatie == 0) //Naar rechts
	{
		setMotorSyncEncoder(motorB,motorC,-100,452,20);
		delay(4000);
	}
	else // Naar links
	{
		setMotorSyncEncoder(motorB,motorC,100,452,20);
		delay(4000);
	}

	return waitForDelivering;
}


enum State waitForDeliveringState() //Sub-test check
{
	bool deliveryAccepted;
	playSoundFile("Boing");
	clearTimer(T4); //Timer 4 resetten en starten
	while(time1[T4] < 10000) //Terwijl er nog geen 10 sec voorbij zijn gegaan:
	{

		int afstand = getUSDistance(S1); //Check afstand naar voren
		if (afstand > 35) //Als de deur open gaat, wordt de afstand groter -> Pakketje leveren
		{
			playSoundFile("Shouting"); //Begroet diegene achter de deur
			deliveryAccepted = true;

			delay(7000); //Delay om niet vaker 'Hey'te roepen
		}
		else
		{
			deliveryAccepted = false;

		}
	}
	if (deliveryAccepted == true)
	{
		return deliverPackage; //Ga door met pakketje leveren
	}
	else
	{
		return makeATurnBack; //Na 10 sec terug terugkeren om terug te gaan.}
	}
}

enum State makeATurnBackState() //Sub-test doet het
{
	int targetColor = getColorName(S2);
	int rotatie;
	if (targetColor == 5 || targetColor == 4) //Als de te bezorgen kleur rood of geel is/ draai rechtsom
	{
		rotatie = 1;
	}
	else if(targetColor == 2 || targetColor == 3) //Als de te bezorgen kleur blauw of groen is/ draai linksom
	{
		rotatie = 0;
	}

	if (rotatie == 0) //Naar links
	{
		setMotorSyncEncoder(motorB,motorC,-100,452,20);
		delay(4000);
	}
	else if (rotatie == 1) // Naar rechts
	{
		setMotorSyncEncoder(motorB,motorC,100,452,20);
		delay(4000);
	}
	return returnToPickupPoint;
}

enum State deliverPackageState() //Sub-test check
{
	//Ride forward
	motor[motorB] = 20;
	motor[motorC] = 20;
	delay (2500);
	motor[motorB] = 0;
	motor[motorC] = 0;
	delay(1000);

	//Drop package
	playSoundFile("Drop load");
	motor[motorD] = -10;
	delay(900);
	motor[motorD] = 0;
	playSoundFile("Okey-dokey");
	delay(2000);

	//Lift arms up again
	motor[motorD] = 10;
	delay(500);
	motor[motorD] = 0;

	//Ride backward
	playSoundFile("Goodbye");
	motor[motorB] = -20;
	motor[motorC] = -20;
	delay (2500);
	motor[motorB] = 0;
	motor[motorC] = 0;

	//Turn to go back
	int targetColor = getColorName(S2);
	int rotatie;
	if (targetColor == 4 || targetColor == 5) //Als de te bezorgen kleur rood of geel is/ draai rechtsom
	{
		rotatie = 0;
	}
	else if(targetColor == 2 || targetColor == 3) //Als de te bezorgen kleur blauw of groen is/ draai linksom
	{
		rotatie = 1;
	}
	if (rotatie == 1) //Naar rechts
	{
		setMotorSyncEncoder(motorB,motorC,-100,452,20);
		delay(4000);
	}
	else if (rotatie == 0) // Naar links
	{
		setMotorSyncEncoder(motorB,motorC,100,452,20);
		delay(4000);
	}
	return  returnToPickupPoint;
}


enum State returnToPickupPointState() //Sub-test check
{
	string endcolor;
	bool blueEnd = false;
	bool redEnd = false;

	int targetColor = getColorName(S2);

	//Check start-color to know end color.
	if (targetColor == 4 || targetColor == 5) //If color is red/yellow, end-point = red
	{
		endcolor = "red";
	}
	else if(targetColor == 2 || targetColor == 3) //If color is blue/green, end-point = blue
	{
		endcolor = "blue";
	}

	//Follow black line segment
	if (endcolor == "blue")
	{
		while (blueEnd == false) //While not at the end, follow black line
		{
			if(getColorName(S3) == 2)//If blue spotted, the end has been reached
			{
				motor[motorB] = 0;
				motor[motorC] = 0;
				blueEnd = true;
			}

			if(getColorName(S3) == 1 || getColorName(S3) == 7)
			{

				motor[motorC] = 25; // Motor C is run at a 0 power level
				motor[motorB] = 0;
				delay(50);
			}
			else if (getColorName(S3) == 6) // If the Light Sensor reads a value greater than or equal to 50
			{
				motor[motorB] = 25; // Motor B is run at a 0 power level
				motor[motorC] = 0; // Motor C is run at a 30 power level
				delay(50);
			}
			else
			{
				motor[motorB] = 20;
				motor[motorC] = 25;
			}
		}
	}
	else if (endcolor == "red") // 5
	{
		while (redEnd == false) //While not at the end, follow black line
		{
			if(getColorName(S3) == 5) //If red is spotted, the end has been reached
			{
				motor[motorB] = 0;
				motor[motorC] = 0;
				redEnd = true;
			}

			if(getColorName(S3) == 1 || getColorName(S3) == 7)
			{

				motor[motorB] = 25; // Motor C is run at a 0 power level
				motor[motorC] = 0;
				delay(50);
			}
			else if (getColorName(S3) == 6) // If the Light Sensor reads a value greater than or equal to 50
			{
				motor[motorB] = 0; // Motor B is run at a 0 power level
				motor[motorC] = 25; // Motor C is run at a 30 power level
				delay(50);
			}
			else
			{
				motor[motorB] = 20;
				motor[motorC] = 25;
			}
		}

	}
	//Drive a bit forward
	motor[motorB] = 25;
	motor[motorC] = 25;
	delay(2500);
	motor[motorB] = 0;
	motor[motorC] = 0;


	if (endcolor == "blue")
	{
		//Turn 180 degrees to be ready for pick-up
		bool timer = false;
		while (timer == false)
		{
			setMotorSyncEncoder(motorB,motorC,-100,904,20);
			delay(8000);
			timer = true;
		}
	}
	else
	{
		bool timer = false;
		while (timer == false)
		{
			setMotorSyncEncoder(motorB,motorC,-100,904,20);
			delay(4000);
			timer = true;
		}
	}

	//Lift arms down
	motor[motorD] = -10;
	delay(500);
	motor[motorD] = 0;

	return waitingFor;
}

enum State emergencyStopState() //Sub-test check
{
	string endcolor;
	bool blueEnd = false;
	bool redEnd = false;

	int targetColor = getColorName(S2);

	//Check start-color to know end color.
	if (targetColor == 4 || targetColor == 5) //If color is red/yellow, end-point = blue
	{
		endcolor = "blue";
	}
	else if(targetColor == 2 || targetColor == 3) //If color is blue/green, end-point = red
	{
		endcolor = "red";
	}

	//Follow black line segment
	if (endcolor == "blue")
	{
		while (blueEnd == false) //While not at the end, follow black line
		{
			if(getColorName(S3) == 2)//If blue spotted, the end has been reached
			{
				motor[motorB] = 0;
				motor[motorC] = 0;
				blueEnd = true;
			}

			if(getColorName(S3) == 1 || getColorName(S3) == 7)
			{

				motor[motorC] = 25; // Motor C is run at a 0 power level
				motor[motorB] = 0;
				delay(50);
			}
			else if (getColorName(S3) == 6) // If the Light Sensor reads a value greater than or equal to 50
			{
				motor[motorB] = 25; // Motor B is run at a 0 power level
				motor[motorC] = 0; // Motor C is run at a 30 power level
				delay(50);
			}
				else
			{
				motor[motorB] = 20;
				motor[motorC] = 25;
			}
		}
	}
	else if (endcolor == "red") // 5
	{
		while (redEnd == false) //While not at the end, follow black line
		{
			if(getColorName(S3) == 5) //If red is spotted, the end has been reached
			{
				motor[motorB] = 0;
				motor[motorC] = 0;
				redEnd = true;
			}

			if(getColorName(S3) == 1 || getColorName(S3) == 7)
			{

				motor[motorB] = 25; // Motor C is run at a 0 power level
				motor[motorC] = 0;
				delay(50);
			}
			else if (getColorName(S3) == 6) // If the Light Sensor reads a value greater than or equal to 50
			{
				motor[motorB] = 0; // Motor B is run at a 0 power level
				motor[motorC] = 25; // Motor C is run at a 30 power level
				delay(50);
			}
			else
			{
				motor[motorB] = 20;
				motor[motorC] = 25;
			}
		}

	}
	//Drive a bit forward
	motor[motorB] = 25;
	motor[motorC] = 25;
	delay(2500);
	motor[motorB] = 0;
	motor[motorC] = 0;


	if (endcolor == "blue")
	{
		//Turn 180 degrees to be ready for pick-up
		bool timer = false;
		while (timer == false)
		{
			setMotorSyncEncoder(motorB,motorC,-100,904,20);
			delay(8000);
			timer = true;
		}
	}
	else
	{
		bool timer = false;
		while (timer == false)
		{
			setMotorSyncEncoder(motorB,motorC,-100,904,20);
			delay(4000);
			timer = true;
		}
	}

	//Lift arms down
	motor[motorD] = -10;
	delay(500);
	motor[motorD] = 0;

	return waitingFor;
}


task main()
{
	clearTimer(T1);
	string state = "Started";
	int status;
	char msgBufIn[20];  // To contain the incoming message.
	char msgBufOut[20];  // To contain the outgoing message
	string IncomingMessage; //To contain the string of the incoming message
	bool checkings = false;

	openMailboxIn("EV3_INBOX0");
	openMailboxOut("EV3_OUTBOX0");
	readMailboxIn("EV3_INBOX0", msgBufIn);



	enum State currentState = waitingFor;
	while (checkings == false)
	{		switch (currentState)
		{
		case waitingFor:
			currentState = waitingState();
			break;
		case scanColorCode:
			currentState = scanColorCodeState();
			break;
		case returnPackage:
			currentState = returnPackageState();
			break;
		case searchBlueSP:
			currentState = searchBlueSPState();
			break;
		case searchRedSP:
			currentState = searchRedSPState();
			break;
		case driveClockwise:
			currentState = driveClockwiseState();
			break;
		case driveCounterClockwise:
			currentState = driveCounterClockWiseState();
			break;
		case turnToDoor:
			currentState = turnToDoorState();
			break;
		case waitForDelivering:
			currentState = waitForDeliveringState();
			break;
		case deliverPackage:
			currentState = deliverPackageState();
			break;
		case returnToPickupPoint:
			currentState = returnToPickupPointState();
			break;
		case makeATurnBack:
			currentState = makeATurnBackState();
			break;
		case emergencyStop:
			currentState = emergencyStopState();
			break;
		}

		if (strcmp(msgBufIn, "") != 0)
	{
		stringFromChars(IncomingMessage,msgBufIn) ; //If c# says start program, robotC program starts
		if(IncomingMessage == "Reset")
		{
			checkings = true;
		}
	}

		if (currentState == driveCounterClockwise || currentState == driveClockwise )
		{state = "Driving";
			status = 25;}
		else if (currentState == searchBlueSP || currentState == searchRedSP)
		{ state = "Starting";
			status = 10;

		}
	else if (currentState == turnToDoor)
		{
			state = "FoundLocation";
			status = 40;
		}
		else if (currentState == deliverPackage)
		{
			state = "Delivering";
			status = 60;
		}
		else if (currentState == makeATurnBack)
		{ state = "ReturningPackage";
			status = 95;}
		else if (currentState == returnToPickupPoint )
		{
			state = "ReturningHome";
			status = 95;
		}
		else if(currentState == waitingFor)
		{
			state = "WaitingFor";
			status = 0;
		}


		int battery = nImmediateBatteryLevel;
		int batteryresult = battery - 6300; //Momenteel voltage - minimum
		batteryresult = batteryresult / 20; //max = 8300, min = 6300. verschil 2000. 20 = 1%
		int runtime = time1[T1];
		sprintf(msgBufOut,"%s %d %d %d",state,runtime,status,batteryresult); //Make msgBufOut string with state

		writeMailboxOut("EV3_OUTBOX0", msgBufOut);

	}

	closeMailboxIn("EV3_INBOX0");
	closeMailboxOut("EV3_OUTBOX0");
	return;
}
