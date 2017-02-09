public class DigitCountThread extends Thread {
	String str;
	int start;
	int end;
	int digitsCount;

	DigitCountThread(int start, int end, String str) {
		this.start = start;
		this.end = end;
		this.str = str;
		digitsCount = 0;
	}

	// Computes the count for the start->end section in the string
	public void run() {
		for (int i = start; i < end; i++) {
			if (Character.isDigit(str.charAt(i)))
				digitsCount++;
		}
		// sync.release();
	}

	public int getDigitsCount() {
		return digitsCount;
	}
}	

