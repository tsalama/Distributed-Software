import java.util.*;

public class AnalyzeString {
	public static void main(String[] args) {
		System.out.println("Please enter a string: ");
		Scanner scan = new Scanner(System.in);
		String str = scan.nextLine();
		System.out.println();

		long startTime = System.currentTimeMillis();
		long endTime = 0;
		
		int numWorkers = 4;
		// Make and start all the workers, keeping them in a list.
		List<DigitCountThread> digitWorkers = new ArrayList<DigitCountThread>();
		List<UpperCountThread> upperWorkers = new ArrayList<UpperCountThread>();
		List<PalindromeThread> palindromeWorkers = new ArrayList<PalindromeThread>();

		int lenOneWorker = str.length() / numWorkers;
		
		for (int i = 0; i < numWorkers; i++) {
			int start = i * lenOneWorker;
			int end = (i + 1) * lenOneWorker;
			
			int palStart = i * (lenOneWorker / 2);
			int palEnd = (i + 1) * (lenOneWorker / 2);
			
			// Special case: make the last worker take up all the excess.
			if (i == numWorkers - 1) end = str.length();
			if (i == (numWorkers / 2)) palEnd = str.length() / 2;
			
			// Create an instance of DigitCountThread
			// Create an instance of UpperCountThread
			DigitCountThread digitWorker = new DigitCountThread(start, end, str);
			UpperCountThread upperWorker = new UpperCountThread(start, end, str);
			PalindromeThread palindromeWorker = new PalindromeThread(palStart, palEnd, str);
	
			digitWorkers.add(digitWorker);
			upperWorkers.add(upperWorker);
			palindromeWorkers.add(palindromeWorker);
			 
			// Start DigitCountThread instance created above
			// Start upperCountThread instance created above
			 
			digitWorker.start();
			upperWorker.start();
			palindromeWorker.start();
		}

		// Wait for the three threads to complete

		try{
			for(int i = 0; i < digitWorkers.size(); i++)
				digitWorkers.get(i).join();
			for(int i = 0; i < upperWorkers.size(); i++)
				upperWorkers.get(i).join();
			for(int i = 0; i < palindromeWorkers.size(); i++)
				palindromeWorkers.get(i).join();
		}
		catch(InterruptedException ignored) {}
				
		endTime = System.currentTimeMillis();

		System.out.println("Time elapsed using threads: " + (endTime - startTime));
		
		// Gather data from workers
		int digitCount = 0;
		int upperCount = 0;
		boolean isPal = true;
		
		for (int i = 0; i < numWorkers; i++)
		{
			System.out.println("\nWorker #" + (i + 1));
			System.out.println("DIGITS | Name:" + digitWorkers.get(i).getName() + " Count:" + digitWorkers.get(i).getDigitsCount());
			digitCount += digitWorkers.get(i).getDigitsCount();
			
			System.out.println("UPPERS | Name:" + upperWorkers.get(i).getName() + " Count:" + upperWorkers.get(i).getUpperCount());
			upperCount += upperWorkers.get(i).getUpperCount();
			
			System.out.println("PALINDROME | Name:" + palindromeWorkers.get(i).getName() + " Same Opposite?:" + palindromeWorkers.get(i).isPalindrome());
			if(!palindromeWorkers.get(i).isPal)
				isPal = false;
		}

		// Display digit count, upper count, and whether the string is a palindrome or not
		System.out.println("\nDigit Count: " + digitCount + "\nUpper Count: " + upperCount + "\nPalindrome? " + (isPal? "Yes" : "No") + "\n");
	}
}
