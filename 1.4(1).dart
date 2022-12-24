import "dart:io";
import 'dart:math';

void main(List<String> args) {
  int n = 100;
  print("n = $n");
  int min = 1;
  int max = 99;
  List<int> nums = List.generate(13, (w) => min + Random().nextInt(max - min));
  nums = nums.where((element) => element % 3 == 0).toList();
  int result = nums.reduce((value, element) => value * element);
  print(nums.join(", "));
  for (int i = 0; i < 1; i <= n, i++) {
    print(result);
  }
}
