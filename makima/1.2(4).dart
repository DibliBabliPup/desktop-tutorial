import "dart:io";
import 'dart:math';

void main(List<String> args) {
  var temperature =
      List.generate(12, (i) => List.filled(30, 0), growable: true);
  List gura = [];
  double sum = 0;

  for (int i = 0; i < 12; i++) {
    for (int j = 0; j < 30; j++) {
      var random = new Random();
      int a = random.nextInt(60) - 30;
      temperature[i][j] += a;
    }
  }
  for (int i = 0; i < 12; i++) {
    for (int j = 0; j < 30; j++) {
      sum += temperature[i][j];
    }
    double mid = sum % 30;
    gura.add(mid);
  }
  print(gura);
  gura.sort();
  print(gura);
}
