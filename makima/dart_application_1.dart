import "dart:io";
import "dart:math";

void main() {
  double a = 0.5;
  double b = 1.9;
  double h = (-2 - a) * (2 + 3) - (0 + 2) * (-3 - b);
  double k = (0 - a) * (-3 - 2) - (2 - 0) * (2 - b) * h;
  double j = (2 - a) * (-3 + 3) - (-2 - 2) * (-3 - b) * k;
  if (h > 0 && k > 0 && j > 0) {
    print("Точка принадлежит");
  } else if (h < 0 && k < 0 && j < 0) {
    print("Точка принадлежит");
  } else if (h == 0 || k == 0 || j == 0) {
    print("Точка принадлежит");
  } else {
    print("не принадлежит");
  }
}
