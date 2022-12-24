import 'dart:io';

void main() {
  try {
    stdout.write("Введите число a: ");
    double a = double.parse(stdin.readLineSync()!);
    stdout.write("Введите число b: ");
    double b = double.parse(stdin.readLineSync()!);

    if (-1 <= a && a <= 3) {
      if (-2 <= b && b <= 4) {
        print(
            "Точка с координатами ($a;$b) принадлежат заштрихованной области");
      } else {
        print(
            "Точка с координатами ($a;$b) не принадлежат заштрихованной области");
      }
    } else {
      print(
          "Точка с координатами ($a;$b) не принадлежат заштрихованной области");
    }
  } catch (e) {
    print(
        "Вы вводите неправильные данные! \nОшибка: $e не является числом \nЗавершение программы.");
  }
}
