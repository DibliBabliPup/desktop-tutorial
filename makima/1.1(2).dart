import "dart:io";
import "dart:math";

void main(List<String> args) {
  print("Введите левую границу: ");
  var min = int.parse(stdin.readLineSync()!);
  print("Введите правую границу: ");
  var max = int.parse(stdin.readLineSync()!);

  List<int> nums = List.generate(15, (w) => min + Random().nextInt(max - min));
  for (int a = 0; a < nums.length; a++) {
    stdout.write((min + Random().nextInt(max - min)));
    stdout.write(" ");
  }
}
