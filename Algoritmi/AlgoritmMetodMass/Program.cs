// Этот метод берет масив и возвращает масив
double[] mass(double[] array) // метод который находит min max и разницу между ними
{
    double sr0 = 0, sr1 = 0, sr2 = 0;
    for (int i = 0; i < 3; i++)
    {
        sr0 = (array[i, 0] + sr0);
        sr1 = (array[i, 1] + sr1);
        sr2 = (array[i, 2] + sr2);
    }
    sr0 = Math.Round((sr0 / 3), 1);
    sr1 = Math.Round((sr1 / 3), 1);
    sr2 = Math.Round((sr2 / 3), 1);
    double[] SrZn = new double[] { 0, 0, 0, };
    SrZn[0] = sr0;
    SrZn[1] = sr1;
    SrZn[2] = sr2;
    return SrZn;
}
