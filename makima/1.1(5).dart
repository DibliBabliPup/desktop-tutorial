import "dart:io";
import 'dart:math';

void main(List<String> args) {
  List<int> nums = [];

  for (int b = 300; b > 1; b = b - 3) {
    int a = (b);

    nums.add(a);
  }

  print(nums);
}
