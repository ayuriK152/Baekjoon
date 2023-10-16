#include <iostream>
#include <vector>
#include <string>
using namespace std;

enum Direction {
	RIGHT,
	DOWN,
	LEFT,
	UP
};

int main() {
	Direction dir = RIGHT;
	vector<int> queue;
	int init = 0;
	int n;
	cin >> n;
	string result;
	int b = 0, w = 0;
	for (int i = 0; i < n; i++) {
		string input;
		cin >> input;
		if (input == "push") {
			cin >> input;
			if (input == "b") {
				if (queue.size() == init)
					queue.push_back(1);
				else if (queue[queue.size() - 1] == -1)
					queue.push_back(1);
				else
					queue[queue.size() - 1]++;
				b++;
			}
			else if (input == "w") {
				queue.push_back(-1);
				w++;
			}
		}
		else if (input == "pop" && queue.size() != init) {
			if (queue[init] <= -1)
				w--;
			else
				b--;
			queue[init]--;
			if (queue[init] <= 0)
				init++;
		}
		else if (input == "rotate") {
			cin >> input;
			if (input == "l")
				dir = (Direction)((dir + 3) % 4);
			else
				dir = (Direction)((dir + 1) % 4);
		}
		else if (input == "count") {
			cin >> input;
			if (input == "b")
				result.append(to_string(b));
			else
				result.append(to_string(w));
			result.append("\n");
		}

		if (queue.size() != init) {
			if (dir == DOWN) {
				if (queue[init] != -1) {
					b -= queue[init];
					init++;
				}
			}
			else if (dir == UP) {
				if (queue[queue.size() - 1] != -1) {
					b -= queue[queue.size() - 1];
					queue.pop_back();
				}
			}
		}
	}
	cout << result;
	return 0;
}