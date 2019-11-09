package com.project;

import java.util.Scanner;

class Atm {
	int cash = 500;
	String pin = "testas";
	Scanner scanner = new Scanner(System.in);

	public void checkPin() {
		System.out.println("Enter PIN");
		boolean pinInput = true;
		int badInputCounter = 0;

		while (pinInput) {
			if (scanner.nextLine().equals(pin)) {
				pinInput = false;
			} else {
				System.out.println("Incorrect PIN, try again");
				badInputCounter++;
				if (badInputCounter >= 3) {
					System.out.println("You account is blocked");
					System.exit(0);
				}
			}
		}
	}

	public void withdraw(int amount) {
		if (amount <= cash) {
			cash -= amount;
			System.out.println("You got " + amount + " in cash.");
		} else {
			System.out.println("Amount you requested is too big. Try again");
			amount = scanner.nextInt();
			withdraw(amount);
		}
	}

	public boolean continueOrNot() {
		System.out.println("Enter 1 to cashout, 2 to end.");
		int input = scanner.nextInt();
		boolean decision = false;

		if (input == 1) {
			decision = true;
		} else if (input == 2) {
			decision = false;
		}
		return decision;
	}

	public boolean isWorking() {
		return cash >= 10;
	}

}

public class Third {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		Atm atm = new Atm();

		atm.checkPin();
		boolean working = true;
		while (working) {
			if (!atm.isWorking()) {
				System.out.println("No more cash in this atm");
				working = false;
				System.exit(0);
			}
			if (atm.continueOrNot()) {
				System.out.println("How much money to withdraw?");
				atm.withdraw(scanner.nextInt());
			} else {
				working = false;
				System.exit(0);
			}
		}
	}

}
