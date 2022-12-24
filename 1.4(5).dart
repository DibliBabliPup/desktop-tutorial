import "dart:io";
import 'dart:math';

void main(List<String> args) {
  print("Введите X");
  double x = double.parse(stdin.readLineSync()!);
  print("Введите Y");
  double y = double.parse(stdin.readLineSync()!);

  if (x > -1 && x < 3) {
    if (y > -2 && y < 4) {
      print("Точка принадлежит координатам a и b");
    } else {
      print("Точка не принадлежит координатам a и b");
    }
  } else {
    print("Точка не принадлежит координатам a и b");
  }
}
