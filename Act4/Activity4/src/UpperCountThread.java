public class UpperCountThread extends Thread {
	String str;
	int start;
	int end;
	int upperCount;

	UpperCountThread(int start, int end, String str) {
		this.start = start;
		this.end = end;
		this.str = str;
		upperCount = 0;
	}

	// Computes the count for the start->end section in the string
	public void run() {
		for (int i = start; i < end; i++) {
			if (Character.isUpperCase((str.charAt(i))))
				upperCount++;
		}
		// sync.release();
	}
	
	public int getUpperCount() {
		return upperCount;
	}
}	

