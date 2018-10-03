
void checkItem()
{
	while (true)
	{
	int color = getColorReflected(S2);
	if (color == 0)
	{
	playSoundFile("Uh-oh");
	}
	delay(1000);
}
}






task main()
{

checkItem();


}
