import "dart:io";
import "dart:math";

void main(List<String> args) {
  int proiz = 1;
  int sumo = 1;
  int numa = 0;
  var nums = [1];
  print(nums);

  for (int a = 0; a < nums.length; a++) {
    print("Добавьте число в список: ");
    int a = int.parse(stdin.readLineSync()!);
    sumo += a;
    if (a != 0) {
      numa++;
      proiz *= a;
      nums.add(a);
      print(nums);
    } else {
      print("Оки-док.");
      break;
    }
    print("Произведение - $proiz");
    print("Сумма - $sumo");
    print("Среднее - $numa");
  }
}
