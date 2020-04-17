using System;

namespace Translater
{
	class SystemsConvertor
	{
		static string strTitle, str;
		static int intDecNumber;

		public static void Menu()
		{
			Console.Clear();
			Console.WriteLine("Systems conversions");
			Console.WriteLine("___________________________");
			Console.WriteLine("1. Character to Binary notation");
			Console.WriteLine("2. A word or sentence to its binary representation");
			Console.WriteLine("3. Binary notation to character");
			Console.WriteLine("4. Binary notation to words");
			Console.WriteLine("5. Binary notation to decimal numeral system");
			Console.WriteLine("6. Binary notation to hexadecimal numeral system");
			Console.WriteLine("7. Decimal numeral system to binary notation");
			Console.WriteLine("8. Decimal to Hexadecimal numeral system: Short method");
			Console.WriteLine("9. Decimal to hexadecimal numeral system: Long method");
			Console.WriteLine("10. Hexadecimal to decimal numeral system");
			Console.WriteLine("11. Hexadecimal to binary notation");
			Console.WriteLine();
		}

		private static void ConvertCharacterToBinary()
		{
			Console.Clear();

			strTitle = "Character to binary system conversion";
			Console.WriteLine("{0}", strTitle);

			Console.Write("Enter the character you want to convert: ");
			char ch = Char.Parse(Console.ReadLine());

			try
			{
				Console.WriteLine("\nCharacter {0} is {1} in binary.", ch, Convert.ToString((int)ch, 2));
			}
			catch (Exception ex)
			{
				Console.WriteLine("Something went wrong while converting: {0}.", ex.Message);
			}
		}

		private static void ConvertStringToBinary()
		{
			Console.Clear();

			strTitle = "String to binary system conversion";
			Console.WriteLine("{0}", strTitle);

			Console.Write("Enter a word: ");
			str = Console.ReadLine();

			System.Text.StringBuilder strBuilder = new System.Text.StringBuilder();
			foreach (char ch in str.ToCharArray())
			{
				strBuilder.Append(Convert.ToString(ch, 2).PadLeft(8, ' '));
			}
			Console.WriteLine(strBuilder);

		}

		private static void ConvertBinaryToCharacter()
		{
			Console.Clear();

			strTitle = "Binary to Character conversion";
			Console.WriteLine("{0}", strTitle);

			Console.Write("Enter a byte: ");
			try{
				int intByte = int.Parse(Console.ReadLine());
				Console.Write((char)Convert.ToInt32(Convert.ToString(Convert.ToInt32(Convert.ToString(Convert.ToInt32(intByte), 10), 2))));
			}catch(FormatException){
				Console.WriteLine("Please enter a byte in integer format.");
			}catch(Exception ex){
				Console.WriteLine("Something went wrong: {0}", ex.Message);
			}
		}

		private static void ConvertBinaryToString()
		{
			Console.Clear();

			strTitle = "Binary system to String conversion";
			Console.WriteLine("{0}", strTitle);

			Console.Write("Enter the number of bytes you want to convert: ");
			try
			{
				int intBytes = int.Parse(Console.ReadLine());
				int[] arrInt = new int[intBytes];

				for (int index = 0; index < intBytes; index++)
				{
					Console.Write("Element[{0}]: ", index);
					arrInt[index] = int.Parse(Console.ReadLine());
				}
				for (int binary = 0; binary < intBytes; binary++)
				{
					Console.Write((char)Convert.ToInt32(Convert.ToString(Convert.ToInt32(Convert.ToString(Convert.ToInt32(arrInt[binary]), 10), 2)))+" ");
				}

			}catch(FormatException){
				Console.WriteLine("Please enter a number and/or a byte in integer format.");
			}catch (Exception ex)
			{
				Console.WriteLine("Something went wrong: {0}.", ex.Message);
			}
		}

		private static void ConvertBinaryToDecimal()
		{
			Console.Clear();

			strTitle = "Binary numeral system to decimal";
			Console.WriteLine("{0}", strTitle);

			Console.Write("Enter byte b: ");
			int intByte = 0;
			try
			{
				intByte = int.Parse(Console.ReadLine());
			}
			catch (OverflowException)
			{
				Console.WriteLine("The number is too large.");
			}
			catch(FormatException ex)
			{
				Console.WriteLine("Something went wrong: {0}",ex.Message);
			}

			string strBinary = Convert.ToString(Convert.ToInt32(Convert.ToString(Convert.ToInt32(intByte), 10), 2));

			if (intByte != 0 && strBinary != "0")
			{
				Console.WriteLine("byte {0} is: {1}", intByte, strBinary);
			}
		}

		private static void ConvertBinaryToHexadecimal()
		{
			Console.Clear();

			strTitle = "Binary notation to Hexidecimal";
			Console.WriteLine("{0}", strTitle);

			Console.WriteLine();
			Console.Write("Enter the number of bytes you want to convert: ");
			try
			{
				int intNumberOfBytes = int.Parse(Console.ReadLine());
				int[] arrBytes = new int[intNumberOfBytes];

				for (int index = 0; index < arrBytes.Length; index++)
				{
					Console.Write("\nByte[{0}]: ", index);
					arrBytes[index] = int.Parse(Console.ReadLine());
				}

				string[] strHex = new string[arrBytes.Length];
				for (int index = 0; index < arrBytes.Length; index++)
				{
					strHex[index] = Convert.ToString(Convert.ToInt32(arrBytes[index]), 10);
					strHex[index] = Convert.ToString(Convert.ToInt32(strHex[index], 2));
				}
				for (int index = 0; index < arrBytes.Length; index++)
				{
					Console.WriteLine("Binary {0} is hexidecimal {1}", arrBytes[index].ToString().PadLeft(8, '0'), Convert.ToString(Convert.ToInt32(strHex[index]), 16).ToUpper());
				}

			}
			catch (OverflowException)
			{
				Console.WriteLine("The number is too large.");
			}catch(FormatException){
				Console.WriteLine("Please enter a number and/or byte integer format");
			}catch(Exception ex){
				Console.WriteLine("Something went wrong: {0}", ex.Message);
			}
		}

		private static void ConvertDecimalToBinary()
		{
			Console.Clear();

			strTitle = "Decimal numeral system to binary";
			Console.WriteLine("{0}", strTitle);

			Console.Write("Enter a decimal: ");
			try
			{
				intDecNumber = int.Parse(Console.ReadLine());
				Console.WriteLine("{0} in binary is {1}", intDecNumber, Convert.ToString(intDecNumber, 2));
			}
			catch (OverflowException)
			{
				Console.WriteLine("The number is too large.");
			}catch(FormatException){
				Console.WriteLine("Please enter integer number.");
			}catch(Exception ex){
				Console.WriteLine("Something went wrong: {0}", ex.Message);
			}
		}

		private static void ConvertDecimalToHexadecimal()
		{
			Console.Clear();

			strTitle = "Decimal numeral system to Hexadecimal: Short method";
			Console.WriteLine("{0,6}", strTitle);

			Console.Write("Enter a Decimal number: ");
			try{
				intDecNumber = int.Parse(Console.ReadLine());
			}catch(FormatException){
				Console.WriteLine("Please enter an integer number");
			}catch(OverflowException){
				Console.WriteLine("The number is too large.");
			}catch(Exception ex){
				Console.WriteLine("Something went wrong: {0}", ex.Message);
			}
			Console.WriteLine("Decimal {0} is {1} in hexadecimal", intDecNumber, Convert.ToString(Convert.ToInt32(intDecNumber), 16).ToUpper());
		}

		private static void ConvertDecimalToHexadecimalLongMethod()
		{
			Console.Clear();

			strTitle = "Decimal to Hexadecimal system conversion: Long method";
			Console.WriteLine("{0}", strTitle);
			try
			{
				int intResult, intRemainder, intCount = 0, intDivisionResult = int.MinValue;
				String[] arrHex = new String[10];

				Console.Write("Enter x: ");
				intDecNumber = int.Parse(Console.ReadLine());

				do
				{
					intResult = intDecNumber / 16;
					intRemainder = intDecNumber % 16;
					if (intResult > 0)
					{
						intDecNumber = intResult;
					}

					intCount++;
					intDivisionResult = intResult;
					arrHex[intCount] = intRemainder.ToString();

					if (intCount + 1 > arrHex.Length)
					{
						String[] extendArrHex = new String[arrHex.Length * 2];
						Array.Copy(arrHex, extendArrHex, intCount);
						arrHex = extendArrHex;
					}

				}
				while (intDivisionResult > 0);

				for (int i = 0; i < arrHex.Length; i++)
				{
					if (arrHex[i] == "10")
					{
						arrHex[i] = "A";
					}
					else if (arrHex[i] == "11")
					{
						arrHex[i] = "B";
					}
					else if (arrHex[i] == "12")
					{
						arrHex[i] = "C";
					}
					else if (arrHex[i] == "13")
					{
						arrHex[i] = "D";
					}
					else if (arrHex[i] == "14")
					{
						arrHex[i] = "E";
					}
					else if (arrHex[i] == "15")
					{
						arrHex[i] = "F";
					}
				}

				Console.Write("The number in hexadecimal is ");
				Array.Reverse(arrHex);
				for (int i = 0; i < arrHex.Length; i++)
				{
					Console.Write("{0}", arrHex[i]);
				}
			}
			catch (OverflowException)
			{
				Console.WriteLine("The number is too large.");
			}catch(FormatException){
				Console.WriteLine("Please enter an integer.");
			}catch(Exception ex){
				Console.WriteLine("Something went wrong: {0}", ex.Message);
			}
		}

		private static void ConvertHexadecimalToDecimal()
		{
			Console.Clear();

			strTitle = "Hexadecimal to decimal system conversion";
			Console.WriteLine("{0}", strTitle);

			Console.Write("Enter hexidemal h: ");
			string hexadecimal = Console.ReadLine();

			Console.WriteLine("Hexadecimal {0} is {1} in decimal numeral system", hexadecimal.ToUpper(), Convert.ToInt32(hexadecimal, 16));
		}

		private static void ConvertHexadecimalToBinary()
		{
			Console.Clear();

			strTitle = "Hexadecimal to binary system conversion";
			Console.WriteLine("{0}", strTitle);

			Console.Write("Enter a hexidecimal number: ");
			string hexadecimal = Console.ReadLine();

			Console.WriteLine("Hexadecimal {0} in binary is {1}", hexadecimal.ToUpper(), Convert.ToString(Convert.ToInt32(hexadecimal, 16), 2));
		}

		private static void Conversions(int option)
		{
			switch (option)
			{
				case 1:
					ConvertCharacterToBinary();
					break;

				case 2:
					ConvertStringToBinary();
					break;

				case 3:
					ConvertBinaryToCharacter();
					break;

				case 4:
					ConvertBinaryToString();
					break;

				case 5:
					ConvertBinaryToDecimal();
					break;

				case 6:
					ConvertBinaryToHexadecimal();
					break;

				case 7:
					ConvertDecimalToBinary();
					break;

				case 8:
					ConvertDecimalToHexadecimal();
					break;

				case 9:
					ConvertDecimalToHexadecimalLongMethod();
					break;
						
				case 10:
					ConvertHexadecimalToDecimal();
					break;

				case 11:
					ConvertHexadecimalToBinary();
					break;
			}
			Console.WriteLine();
		}

		private static void ConversionsHandler()
		{
			try
			{
				Console.Clear();
				Menu();
				Console.Write("Choose option: ");
				int intOption = int.Parse(Console.ReadLine());

				if (intOption < 1 | intOption > 11)
				{
					do
					{
						Console.Write("Enter a number in the range of 1 to 11: ");
						try
						{
							intOption = int.Parse(Console.ReadLine());
						}
						catch (OverflowException)
						{
							Console.WriteLine("The number is too large.");
						}
					} while (intOption < 1 | intOption > 11);
					Conversions(intOption);
				}
				else
				{
					Conversions(intOption);
				}

				Console.Write("Do you want to continue with the program y/n?: ");
				string strContinue = Console.ReadLine();

				if (strContinue.ToLower() != "yes" && strContinue.ToLower() != "y" && strContinue.ToLower() != "no" && strContinue.ToLower() != "n")
				{
					Console.WriteLine("Input yes or y to continue OR no or n to terminate. Please re-run the program");
				}
				else if (strContinue.ToLower() == "no" | strContinue.ToLower() == "n")
				{
					Console.WriteLine("The program has been terminated. See you next time ;)");
				}
				else if(strContinue.ToLower() == "yes" | strContinue.ToLower() == "y"){
					ConversionsHandler();
				}
				Console.WriteLine();
			}
			catch (FormatException)
			{
				Console.WriteLine("Wrong input, please re-run the program");
			}
		}

		public static void Main(string[] args)
		{
			ConversionsHandler();
		}
	}
}

