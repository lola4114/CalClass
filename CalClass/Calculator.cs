namespace CalClass;

public static class Calculator
{

	public static double Calculate(double num1, double num2, string mathoperator)
	{
		double resultat = 0;
		switch(mathoperator)
		{
			case "+":
				resultat = num1 + num2; break;
            case "-":
                resultat = num1 - num2; break;
            case "x":
                resultat = num1 * num2; break;
            case "÷":
                resultat = num1 / num2; break;


        }
		return resultat;
	}

}

public static class DoubleExtensions
{
    public static string ToTrimmedString(this double target, string decimalFormat)
    {
        string strValue = target.ToString(decimalFormat); //Get the stock string

        //If there is a decimal point present
        if (strValue.Contains("."))
        {
            //Remove all trailing zeros
            strValue = strValue.TrimEnd('0');

            //If all we are left with is a decimal point
            if (strValue.EndsWith(".")) //then remove it
                strValue = strValue.TrimEnd('.');
        }

        return strValue;
    }

}