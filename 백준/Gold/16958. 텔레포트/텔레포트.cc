#include <iostream>
#include <string>
using namespace std;

class City {
public:
	int s, x, y;
	City() {}
	City(int _s, int _x, int _y) {
		s = _s;
		x = _x;
		y = _y;
	}
};

int main() {
	City cities[1000];
	int n, t, sCityCnt = 0;
	cin >> n >> t;
	for (int i = 0; i < n; i++) {
		int s, x, y;
		cin >> s >> x >> y;
		cities[i] = City(s, x, y);
		sCityCnt += s == 1 ? 1 : 0;
	}
	int m;
	cin >> m;
	string result = "";
	for (int i = 0; i < m; i++) {
		int a, b;
		cin >> a >> b;
		int min = abs(cities[b - 1].x - cities[a - 1].x) + abs(cities[b - 1].y - cities[a - 1].y);
		if (cities[a - 1].s == 1) {
			if (cities[b - 1].s == 1)
				min = min > t ? t : min;
			else if (sCityCnt > 1) {
				int routeMin = 2001;
				for (int i = 0; i < n; i++) {
					if (cities[i].s == 1) {
						int temp = abs(cities[b - 1].x - cities[i].x) + abs(cities[b - 1].y - cities[i].y);
						routeMin = routeMin > temp ? temp : routeMin;
					}
				}
				min = min > routeMin + t ? routeMin + t : min;
			}
		}
		else {
			if (cities[b - 1].s == 1 && sCityCnt > 1) {
				int routeMin = 2001;
				for (int i = 0; i < n; i++) {
					if (cities[i].s == 1) {
						int temp = abs(cities[a - 1].x - cities[i].x) + abs(cities[a - 1].y - cities[i].y);
						routeMin = routeMin > temp ? temp : routeMin;
					}
				}
				min = min > routeMin + t ? routeMin + t : min;
			}
			else if (min > t && sCityCnt > 1) {
				int routeMinA = 2001, routeMinB = 2001;
				for (int i = 0; i < n; i++) {
					if (cities[i].s == 1) {
						int temp = abs(cities[a - 1].x - cities[i].x) + abs(cities[a - 1].y - cities[i].y);
						routeMinA = routeMinA > temp ? temp : routeMinA;
					}
				}
				for (int i = 0; i < n; i++) {
					if (cities[i].s == 1) {
						int temp = abs(cities[b - 1].x - cities[i].x) + abs(cities[b - 1].y - cities[i].y);
						routeMinB = routeMinB > temp ? temp : routeMinB;
					}
				}
				min = min > routeMinA + routeMinB + t ? routeMinA + routeMinB + t : min;
			}
		}
		result.append(to_string(min));
		result.append("\n");
	}
	cout << result;
	return 0;
}