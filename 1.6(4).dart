import "dart:io";
import "dart:math";

void main() {
  int sum = 0;
  print("Введите а: ");
  int a = int.parse(stdin.readLineSync()!);

  while (true) {
    print("Добавьте число в список: ");
    int b = int.parse(stdin.readLineSync()!);
    if (b >= 0 && b % a == 0) {
      sum += b;
    } else {
      print("Оки-док.");
      break;
    }
  }
  print("Сумма = $sum");
}
