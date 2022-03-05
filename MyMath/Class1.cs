namespace MyMath;


public class Rooter {
    public double SquareRoot(double input) {
        if (input <= 0.0) {
            throw new ArgumentOutOfRangeException(paramName: nameof(input));
        }

        double result = input;
        double previousResult = -input;

        while (Math.Abs(previousResult - result) > result / 1000) {
            previousResult = result;
            result = (result + input / result) / 2;
        }

        return result;
    }
}
