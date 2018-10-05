
void checkDistanceDrive()
{

int distance = getUSDistance(S1);

	while (distance > 30)
	{
		distance =getUSDistance(S1);
		displayCenteredBigTextLine(2, "%d", distance);
		motor[motorB] = 10;
		motor[motorC] = 10;
		delay(1000);
		motor[motorB] = 0;
		motor[motorC] = 0;
		distance = 0;
	}

}

task main()
{


while (true)
{
checkDistanceDrive();
}

}
