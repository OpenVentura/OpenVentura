import java.lang.Math;
import java.util.Random;

public class Generator {

    public static void main(String[] args) {

        Random seedGenerator1 = new Random();
        int seed_1 = seedGenerator1.nextInt(2147483647);
        Random seedGenerator2 = new Random();
        int seed_2 = seedGenerator2.nextInt(2147483647);
        Random seedGenerator3 = new Random();
        int seed_3 = seedGenerator3.nextInt(2147483647);
        Random seedGenerator4 = new Random();
        int seed_4 = seedGenerator4.nextInt(2147483647);
        Random isMultiplier = new Random(seed_1);
        int Mul = isMultiplier.nextInt(2);
        Random isDivider = new Random(seed_2);
        int Div = isDivider.nextInt(2);
        Random isSubtract = new Random(seed_3);
        int Sub = isSubtract.nextInt(2);
        Random isAdd = new Random(seed_4);
        int Add = isAdd.nextInt(2);
        Random r1 = new Random(seed_1);
        int rValue_1 = r1.nextInt(2147483647);
        Random r2 = new Random(seed_2);
        int rValue_2 = r2.nextInt(2147483647);
        Random r3 = new Random(seed_3);
        int rValue_3 = r3.nextInt(2147483647);
        Random r4 = new Random(seed_4);
        int rValue_4 = r4.nextInt(2147483647);
        Random r5 = new Random(seed_1);
        int rValue_5 = r5.nextInt(2147483647);
        Random r6 = new Random(seed_2);
        int rValue_6 = r6.nextInt(2147483647);
        Random r7 = new Random(seed_3);
        int rValue_7 = r7.nextInt(2147483647);
        Random r8 = new Random(seed_4);
        int rValue_8 = r8.nextInt(2147483647);
        Random BaseValue = new Random();
        int Value = BaseValue.nextInt(2147483647);
        int MultiplierValue = 0;
        int Min_MultiplierValue = rValue_1;
        int Max_MultiplierValue = rValue_2;
        int Range_MultiplierValue = Min_MultiplierValue - Max_MultiplierValue + 1;
        for (int i = 0; i < 10; i++) {
            MultiplierValue = (int) (Math.random() * Range_MultiplierValue) + Min_MultiplierValue;
        }
        int DividerValue = 1;
        int Min_DividerValue = rValue_3;
        int Max_DividerValue = rValue_4;
        int Range_DividerValue = Min_DividerValue - Max_DividerValue + 1;
        for (int i = 0; i < 10; i++) {
            DividerValue = (int) (Math.random() * Range_DividerValue) + Min_DividerValue;
        }
        int SubtractValue = 0;
        int Min_SubtractValue = rValue_5;
        int Max_SubtractValue = rValue_6;
        int Range_SubtractValue = Min_SubtractValue - Max_SubtractValue + 1;
        for (int i = 0; i < 10; i++) {
            SubtractValue = (int) (Math.random() * Range_SubtractValue) + Min_SubtractValue;
        }
        int AdditionValue = 0;
        int Min_AdditionValue = rValue_7;
        int Max_AdditionValue = rValue_8;
        int Range_AdditionValue = Min_AdditionValue - Max_AdditionValue + 1;
        for (int i = 0; i < 10; i++) {
            AdditionValue = (int) (Math.random() * Range_AdditionValue) + Min_AdditionValue;
        }
        int ValueMul = 0;
        int ValueSub = 0;
        int ValueAdd = 0;
        int ValueDiv = 2;
        if(Mul == 1) {
            ValueMul = Value * MultiplierValue;
        }
        if(Div == 1) {
            ValueDiv = Value / DividerValue;
        }
        if(Sub == 1) {
            ValueSub = Value - SubtractValue;
        }
        if(Add == 1) {
            ValueAdd = Value + AdditionValue;
        }
        int FinalValue;
        FinalValue = Value * ValueMul / ValueDiv - ValueSub + ValueAdd;
        System.out.println(FinalValue);
    }
}
