string? sideA = "";
string? sideB = "";
string? sideC = "";
string? angleA = "";
string? angleB = "";
string? angleC = "";
double realTriangle;
double radiansToDegrees = 180 / Math.PI;
double degreesToRadians = Math.PI / 180;

void CollectValues()
{
    TextColorGreen();
    Console.WriteLine("Welcome! This program is designed to solve triangles. \nThis program takes in three values of your choosing and outputs six values: Three side lengths and three angle measurements.");
    Console.WriteLine("For the angles and/or side lengths you have chosen to exclude, leave the space blank and press enter to continue.");
    Console.WriteLine("After enterinig a value, press enter to continue");
    Console.WriteLine("Please exclude units.");
    Console.ResetColor();

    Console.Write("Side a: ");
    sideA = Console.ReadLine();

    Console.Write("Side b: ");
    sideB = Console.ReadLine();

    Console.Write("Side c: ");
    sideC = Console.ReadLine();

    Console.Write("Angle A: ");
    angleA = Console.ReadLine();

    Console.Write("Angle B: ");
    angleB = Console.ReadLine();

    Console.Write("Angle C: ");
    angleC = Console.ReadLine();

    if (sideA == "" && sideB == "" && sideC == "" && angleA != "" && angleB != "" && angleC != "")
    {
        Console.WriteLine("Please provide at least one side length.");
        CollectValues();
    }

    if (sideA.Contains("-") || sideB.Contains("-") || sideC.Contains("-") || angleA.Contains("-") || angleB.Contains("-") || angleC.Contains("-"))
    {
        Console.WriteLine("Please provide only positive values");
        CollectValues();
    }

    else if (sideA == "" && sideB == "" && sideC != "" && angleA == "" && angleB != "" && angleC != "")
    {
        if (CheckAngles(Convert.ToDouble(angleB), Convert.ToDouble(angleC)))
        {
            SAA(Convert.ToDouble(sideC), Convert.ToDouble(angleB), Convert.ToDouble(angleC));
        }
    }

    else if (sideA == "" && sideB == "" && sideC != "" && angleA != "" && angleB == "" && angleC != "")
    {
        if (CheckAngles(Convert.ToDouble(angleA), Convert.ToDouble(angleC)))
            SAA(Convert.ToDouble(sideC), Convert.ToDouble(angleA), Convert.ToDouble(angleC));
    }

    else if (sideA == "" && sideB == "" && sideC != "" && angleA != "" && angleB != "" && angleC == "")
    {
        if (CheckAngles(Convert.ToDouble(angleA), Convert.ToDouble(angleB)))
            ASA(Convert.ToDouble(angleA), Convert.ToDouble(sideC), Convert.ToDouble(angleB));
    }

    else if (sideA == "" && sideB != "" && sideC == "" && angleA == "" && angleB != "" && angleC != "")
    {
        if (CheckAngles(Convert.ToDouble(angleB), Convert.ToDouble(angleC)))
            SAA(Convert.ToDouble(sideB), Convert.ToDouble(angleC), Convert.ToDouble(angleB));
    }

    else if (sideA == "" && sideB != "" && sideC == "" && angleA != "" && angleB == "" && angleC != "")
    {
        if (CheckAngles(Convert.ToDouble(angleA), Convert.ToDouble(angleC)))
            ASA(Convert.ToDouble(angleA), Convert.ToDouble(sideB), Convert.ToDouble(angleC));
    }

    else if (sideA == "" && sideB != "" && sideC != "" && angleA == "" && angleB == "" && angleC != "")
    {
        if (CheckAngles(0, Convert.ToDouble(angleC)))
            SSA(Convert.ToDouble(sideC), Convert.ToDouble(sideB), Convert.ToDouble(angleC));
    }

    else if (sideA == "" && sideB != "" && sideC != "" && angleA == "" && angleB != "" && angleC == "")
    {
        if (CheckAngles(0, Convert.ToDouble(angleB)))
            SSA(Convert.ToDouble(sideB), Convert.ToDouble(sideC), Convert.ToDouble(angleB));
    }

    else if (sideA == "" && sideB != "" && sideC != "" && angleA != "" && angleB == "" && angleC == "")
    {
        if (CheckAngles(0, Convert.ToDouble(angleA)))
            SAS(Convert.ToDouble(sideB), Convert.ToDouble(angleA), Convert.ToDouble(sideC));
    }

    else if (sideA != "" && sideB == "" && sideC == "" && angleA == "" && angleB != "" && angleC != "")
    {
        if (CheckAngles(Convert.ToDouble(angleB), Convert.ToDouble(angleC)))
            ASA(Convert.ToDouble(angleB), Convert.ToDouble(sideA), Convert.ToDouble(angleC));
    }

    else if (sideA != "" && sideB == "" && sideC == "" && angleA != "" && angleB == "" && angleC != "")
    {
        if (CheckAngles(Convert.ToDouble(angleA), Convert.ToDouble(angleC)))
            SAA(Convert.ToDouble(sideA), Convert.ToDouble(angleC), Convert.ToDouble(angleA));
    }

    else if (sideA != "" && sideB == "" && sideC == "" && angleA != "" && angleB != "" && angleC == "")
    {
        if (CheckAngles(Convert.ToDouble(angleA), Convert.ToDouble(angleB)))
            SAA(Convert.ToDouble(sideA), Convert.ToDouble(angleB), Convert.ToDouble(angleA));
    }

    else if (sideA != "" && sideB == "" && sideC != "" && angleA == "" && angleB == "" && angleC != "")
    {
        if (CheckAngles(0, Convert.ToDouble(angleC)))
            SSA(Convert.ToDouble(sideC), Convert.ToDouble(sideA), Convert.ToDouble(angleC));
    }

    else if (sideA != "" && sideB == "" && sideC != "" && angleA == "" && angleB != "" && angleC == "")
    {
        if (CheckAngles(0, Convert.ToDouble(angleB)))
            SAS(Convert.ToDouble(sideA), Convert.ToDouble(angleB), Convert.ToDouble(sideC));
    }

    else if (sideA != "" && sideB == "" && sideC != "" && angleA != "" && angleB == "" && angleC == "")
    {
        if (CheckAngles(0, Convert.ToDouble(angleA)))
            SSA(Convert.ToDouble(sideA), Convert.ToDouble(sideC), Convert.ToDouble(angleA));
    }

    else if (sideA != "" && sideB != "" && sideC == "" && angleA == "" && angleB == "" && angleC != "")
    {
        if (CheckAngles(0, Convert.ToDouble(angleC)))
            SAS(Convert.ToDouble(sideA), Convert.ToDouble(angleC), Convert.ToDouble(sideB));
    }

    else if (sideA != "" && sideB != "" && sideC == "" && angleA == "" && angleB != "" && angleC == "")
    {
        if (CheckAngles(0, Convert.ToDouble(angleB)))
            SSA(Convert.ToDouble(sideB), Convert.ToDouble(sideA), Convert.ToDouble(angleB));
    }

    else if (sideA != "" && sideB != "" && sideC == "" && angleA != "" && angleB == "" && angleC == "")
    {
        if (CheckAngles(0, Convert.ToDouble(angleA)))
            SSA(Convert.ToDouble(sideA), Convert.ToDouble(sideB), Convert.ToDouble(angleA));
    }

    else if (sideA == "" && sideB != "" && sideC == "" && angleA != "" && angleB != "" && angleC == "")
    {
        SAA(Convert.ToDouble(sideB), Convert.ToDouble(angleA), Convert.ToDouble(angleB));
    }

    else if (sideA != "" && sideB != "" && sideC != "" && angleA == "" && angleB == "" && angleC == "")
    {
        realTriangle = Convert.ToDouble(sideA) + Convert.ToDouble(sideB);
        if (realTriangle <= Convert.ToDouble(sideC))
        {
            Console.WriteLine("This is not a real triangle");
        }
        else
        {
            realTriangle = Convert.ToDouble(sideB) + Convert.ToDouble(sideC);
            if (realTriangle <= Convert.ToDouble(sideA))
            {
                Console.WriteLine("This is not a real triangle");
            }
            else
            {
                realTriangle = Convert.ToDouble(sideA) + Convert.ToDouble(sideC);
                if (realTriangle <= Convert.ToDouble(sideB))
                {
                    Console.WriteLine("This is not a real triangle");
                }
                else
                {
                    Console.WriteLine("This is a real triangle");
                    SSS(Convert.ToDouble(sideA), Convert.ToDouble(sideB), Convert.ToDouble(sideC));
                }

            }
        }
    }

    else
    {
        Console.WriteLine("Please provide exactly three values, with at least one of them being a side length.");
    }
}

void SSS(double sideX, double sideY, double sideZ)
{
    double angleX = Math.Acos(((sideY * sideY) + (sideZ * sideZ) - (sideX * sideX)) / (2 * sideY * sideZ)) * radiansToDegrees;
    double angleY = Math.Acos(((sideX * sideX) + (sideZ * sideZ) - (sideY * sideY)) / (2 * sideX * sideZ)) * radiansToDegrees;
    double angleZ = Math.Acos(((sideX * sideX) + (sideY * sideY) - (sideZ * sideZ)) / (2 * sideX * sideY)) * radiansToDegrees;

    DisplayValues(angleX, angleY, angleZ, sideX, sideY, sideZ);
}

void SAS(double sideX, double angleY, double sideZ)
{
    double sideY = Math.Sqrt((sideX * sideX) + (sideZ * sideZ) - (2 * sideX * sideZ * (Math.Cos(angleY * degreesToRadians))));
    double angleX = Math.Acos(((sideY * sideY) + (sideZ * sideZ) - (sideX * sideX)) / (2 * sideY * sideZ)) * radiansToDegrees;
    double angleZ = Math.Acos(((sideX * sideX) + (sideY * sideY) - (sideZ * sideZ)) / (2 * sideX * sideY)) * radiansToDegrees;

    DisplayValues(angleX, angleY, angleZ, sideX, sideY, sideZ);
}

void SSA(double sideX, double sideY, double angleX)
{
    double angleY = Math.Asin((sideY / sideX) * Math.Sin(angleX * degreesToRadians)) * radiansToDegrees;
    if (180 - angleX - angleY > 0)
    {
        double angleZ = 180 - angleX - angleY;
        double sideZ = ((Math.Sin(angleZ * degreesToRadians) / Math.Sin(angleX * degreesToRadians)) * sideX);
        double angleY2 = 180 - angleY;
        if (180 - angleX - angleY2 > 0)
        {
            double angleX2 = angleX;
            double sideX2 = sideX;
            double sideY2 = sideY;
            double angleZ2 = 180 - angleX2 - angleY2;
            double sideZ2 = ((Math.Sin(angleZ2 * degreesToRadians) / Math.Sin(angleX2 * degreesToRadians)) * sideX2);

            Console.WriteLine("This SSA case relates to two triangles.");
            Console.WriteLine("Case 1");
            DisplayValues(angleX, angleY, angleZ, sideX, sideY, sideZ);
            Console.WriteLine("Case 2:");
            DisplayValues(angleX2, angleY2, angleZ2, sideX2, sideY2, sideZ2);
        }
        else
        {
            Console.WriteLine("This SSA case relates to one triangle.");
            DisplayValues(angleX, angleY, angleZ, sideX, sideY, sideZ);
        }
    }
    else
    {
        Console.WriteLine("This SSA case relates to no triangles.");
    }
}

void ASA(double angleX, double sideY, double angleZ)
{
    double angleY = 180 - angleX - angleZ;
    double sideX = ((Math.Sin(angleX * degreesToRadians) / Math.Sin(angleY * degreesToRadians)) * sideY);
    double sideZ = ((Math.Sin(angleZ * degreesToRadians) / Math.Sin(angleY * degreesToRadians)) * sideY);

    DisplayValues(angleX, angleY, angleZ, sideX, sideY, sideZ);
}

void SAA(double sideX, double angleY, double angleX)
{
    double angleZ = 180 - angleY - angleX;
    double sideY = ((Math.Sin(angleY * degreesToRadians) / Math.Sin(angleX * degreesToRadians)) * sideX);
    double sideZ = ((Math.Sin(angleZ * degreesToRadians) / Math.Sin(angleX * degreesToRadians)) * sideX);

    DisplayValues(angleX, angleY, angleZ, sideX, sideY, sideZ);

}

void DisplayValues(double X, double Y, double Z, double x, double y, double z)
{
    TextColorGreen();
    Console.WriteLine("Side x is across from angle X.");
    Console.WriteLine("Side y is across from angle Y.");
    Console.WriteLine("Side z is across from angle Z.");
    TextColorRed();
    Console.WriteLine($"Side x: {Math.Round(x, 3)}");
    Console.WriteLine($"Side y: {Math.Round(y, 3)}");
    Console.WriteLine($"Side z: {Math.Round(z, 3)}");
    Console.WriteLine($"Angle X: {Math.Round(X, 3)}");
    Console.WriteLine($"Angle Y: {Math.Round(Y, 3)}");
    Console.WriteLine($"Angle Z: {Math.Round(Z, 3)}");
    TextColorGreen();
    Console.WriteLine($"Adjust labels as nessesary");
    Console.ResetColor();
}

CollectValues();

bool CheckAngles(double angle1, double angle2)
{
    if (angle1 + angle2 < 180)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void TextColorGreen()
{
    Console.ForegroundColor = ConsoleColor.Green;
}

void TextColorRed()
{
    Console.ForegroundColor = ConsoleColor.Red;
}