import "dart:io";
import "dart:math";

void main() {
  print('Введите некоторое кол-во слов через пробел');
  String characters = stdin.readLineSync()!;
  List<String> a = characters.split(" ");
  print("Кол-во слов - ${a.length}");
}
