#include <iostream>
#include <sstream>

using namespace std;

class Deque {
public:
	string arr[100000];
	int count, first, last;
	bool isReverse;
	bool isError;
	Deque(int size) {
		count = size;
		first = 0;
		last = size - 1;
		isReverse = false;
		isError = false;
	}

	void Reverse() {
		isReverse = !isReverse;
	}

	void Delete() {
		if (first > last || count == 0 || isError) {
			isError = true;
			return;
		}
		if (!isReverse) {
			first++;
			count--;
		}
		else {
			last--;
			count--;
		}
	}
	
	string ShowAll() {
		string result;
		if (isError)
			result = "error";
		else if (count == 0)
			result = "[]";
		else if (!isReverse) {
			result += "[";
			for (int i = first; i <= last; i++) {
				result += arr[i] + ",";
			}
			result[result.length() - 1] = ']';
		}
		else {
			result += "[";
			for (int i = last; i >= first; i--) {
				result += arr[i] + ",";
			}
			result[result.length() - 1] = ']';
		}
		return result;
	}
};

int main() {
	int t;
	cin >> t;

	for (int i = 0; i < t; i++) {
		string p;
		cin >> p;

		int n;
		cin >> n;
		Deque deque(n);

		string input;
		cin >> input;
		input = input.substr(1, input.length() - 2);
		istringstream iss(input);

		for (int j = 0; j < n; j++)
			getline(iss, deque.arr[j], ',');
		for (int j = 0; j < p.length(); j++) {
			switch (p[j]) {
			case 'R':
				deque.Reverse();
				break;
			case 'D':
				deque.Delete();
				break;
			}
		}
		cout << deque.ShowAll() << endl;
	}
	return 0;
}