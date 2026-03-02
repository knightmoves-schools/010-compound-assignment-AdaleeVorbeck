namespace knightmoves;
public class Calculator
{
    public int Addition = 50;
    public int Subtraction = 40;
    public int Multiplication = 5;
    public int Division = 6;

    public void Calculate(){
        // Add your code here
        Addition = Addition + 5;
        Subtraction = Subtraction - 1;
        Multiplication = Multiplication * 7;
        Division = Division / 2;
    }
}

//should use compound assignment to add 5 to the Addition
//should use compound assignment to subtract 1 from the Subtraction
//should use compound assignment to multiply the Multiplication by 7
//should use compound assignment to divide the Division by 2