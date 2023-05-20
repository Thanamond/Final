using System;

class Program
{
    
	static bool IsValidSequence(string halfDNASequence)
    {
	    foreach(char nucleotide in halfDNASequence)
	    {
    	    if(!"ATCG".Contains(nucleotide))
    	    {
        	    return false;
    	    }
	    }
	    return true;
    }

    static string ReplicateSeqeunce(string halfDNASequence)
    {
		string result = "";
	    foreach(char nucleotide in halfDNASequence)
	    {
    	    result += "TAGC"["ATCG".IndexOf(nucleotide)];
	    }
	    return result;
	}

    static void Main(string[] args)
    {
        bool continueProgram = true;

        do{
            Console.Write("input DNA : ");
            string halfDNA = Console.ReadLine();

            bool continueProgram2 = true;

            do{
                if (IsValidSequence(halfDNA))
                {
                    
                    Console.WriteLine("Current half DNA sequence: " + halfDNA);

                    Console.Write("Do you want to replicate it? (Y/N): ");
                    string choice = Console.ReadLine();

                    if (choice == "Y")
                    {
                        string replicatedHalfDNA = ReplicateSeqeunce(halfDNA);
                        Console.WriteLine("Replicated half DNA sequence: " + replicatedHalfDNA);
                    }
                    else if (choice == "N")
                    {
                        continueProgram2 = false;
                    }
                    else
                    {
                        Console.WriteLine("Please input Y or N.");
                        continue; 
                    }
                }
                else
                {
                    Console.WriteLine("That half DNA sequence is invalid.");
                    continueProgram2 = false;
                }
            }while(continueProgram2);

            Console.Write("Do you want to process another sequence? (Y/N): ");
            string programChoice = Console.ReadLine();
            if (programChoice == "Y")
            {
                continue; 
            }
            else if (programChoice == "N")
            {
                continueProgram = false; 
            }
            else
            {
                Console.WriteLine("Please input Y or N.");
                continue; 
            }

        }while(continueProgram);
	}
}
