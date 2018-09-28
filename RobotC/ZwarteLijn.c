task main()
{
	int mValue = 30; // Motor power
	int threshold = 50; // Light sensor threshold
	bool firsttouch = false;
	bool secondtouch = false;




	while(secondtouch == false)
	{
	while(firsttouch == false)
	{
		if(SensorValue[S3] < threshold) // If the Light Sensor reads a value less than 50
		{
			motor[motorC] = mValue; // Motor D is run at a 30 power level
			motor[motorB] = 0; // Motor E is run at a 0 power level
		}
		else // If the Light Sensor reads a value greater than or equal to 50
		{
			motor[motorB] = mValue; // Motor E is run at a 30 power level
			motor[motorC] = 0; // Motor D is run at a 0 power level
		}

		if (getTouchValue(S1) == 1) //If bumps into something, stop the loop.
		{
			firsttouch = true;
			motor[motorB] = 0; // Turn off both motors
			motor[motorC] = 0;
			//*To add: communicate to C# that the robot bumped into something, followed by the C# application turning the touch bool into true again*
			//*Change: motor code to motorsync*
		}

	}
	if (getButtonPress(buttonEnter) == 1) //Turn the robot on again
	{
		firsttouch = false;
	}
}
}
