import 'dart:io';
import 'dart:convert';
import 'dart:async';

void main() {
  var inputFile = File("tututu//kobeni.txt");
  var result = File("tututu//power.txt").openWrite();
  var contentInput = inputFile.readAsLinesSync();
  List<String> nums = contentInput;
  List<String> LuckyNums = nums[0].split(" ");
  int b = 2;
  for (int f = 0; f < int.parse(nums[1]); f++) {
    int k = 0;
    List<String> bilet = nums[b].split(" ");
    for (int i = 0; i < LuckyNums.length; i++) {
      for (int g = 0; g < 5; g++) {
        if (LuckyNums[i] == bilet[g]) {
          ++k;
        } else {
          k = k;
        }
      }
    }
    ++b;
    if (k >= 3) {
      print("Lucky");
      result.write("Lucky\n");
    } else {
      print("Unlucky");
      result.write("Unlucky\n");
    }
  }
  ++b;
}
