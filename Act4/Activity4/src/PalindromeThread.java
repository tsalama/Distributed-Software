public class PalindromeThread extends Thread {
	String str;
	int start;
	int end;
	boolean isPal;

	PalindromeThread(int start, int end, String str) {
		this.start = start;
		this.end = end;
		this.str = str;
		this.isPal = true;
	}

	// Computes the count for the start->end section in the string
	public void run() {
		for (int i = start; i < end; i++) {
			char ch1 = Character.toLowerCase((str.charAt(i)));
			char ch2 = Character.toLowerCase((str.charAt(str.length() - 1 - i)));

			if (i < str.length() / 2 && ch1 != ch2)
				isPal = false;
		}
		// sync.release();
	}

	public boolean isPalindrome() {
		return isPal;
	}	
}

