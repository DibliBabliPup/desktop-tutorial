import "dart:io";
import 'dart:math';

void main(List<String> args) {
  int f = 5;
  List<List<int>> matrix = [
    [0, 0, 0, 0, 0],
    [0, 0, 0, 0, 0],
    [0, 0, 0, 0, 0],
    [0, 0, 0, 0, 0],
    [0, 0, 0, 0, 0]
  ];
  for (int i = 0; i < f; i++) {
    for (int j = 0; j < f; j++) {
      if (i == 0 || j == 0) {
        matrix[i][j] = 1;
      } else {
        matrix[i][j] = matrix[i - 1][j] + matrix[i][j - 1];
      }
    }
  }
  for (int i = 0; i < f; i++) {
    for (int j = 0; j < f; j++) {
      stdout.write("${matrix[i][j]} ");
    }
    print(" ");
  }
}
