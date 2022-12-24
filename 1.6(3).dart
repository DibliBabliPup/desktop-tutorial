import "dart:io";
import "dart:math";

void main(List<String> args) {
  print("Число: ");
  int a = int.parse(stdin.readLineSync()!);
  int b = a % 2;
  int c = a % 10;
  if (b == 0 && c == 0) {
    print("Число чётное и кратно 10");
  } else if (b == 0 && c != 0) {
    print("Число чётное, некратно 10");
  } else if (b != 0 && c != 0) {
    print("Число нечётное, некратно 10");
  }
}
