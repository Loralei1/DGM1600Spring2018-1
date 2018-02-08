using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperators : MonoBehaviour {

	public int A;
	public int B;
	public int C;

	void Start () {

	// These are all basic algebraic equations using math operators. 
	
		
		if (B + A == C)
		{ 
			print(C);
		}
		if (C - A == B)
		{
			print(B);
		}

		if (A * B == C)
		{
			print(C);
		}

		if (A / B == C)
		{ 
			print (C);
		}
		/* Division can be done only if the integers 
		going in will result in a whole number, or 
		if the variables used are floats. */

		if (A % B == C)
		{ 
			print (C);
		}
		/*The above equation will print the modulus of A and B, or the remainder left over after dividing A and B. 
		I'm assuming that this also has to be done with either integers that will result in whole
		numbers or using floats as the variable. */
		if (A <= 0)
		{
			A++;
		}
		/*This will add one as long as A is less than or equal to zero. A++ is a shortcut for adding one. . */

		if (A >= 10)
		{
			A--; 
		}
		/* Same, but A-- is a shortcut for subtracting one. */

		C = A + B; // Equations tend to be written sum/difference first when using C#
		C += A = B; 
		/* If C, A, and B are all assigned values of ten, the top equation will equal 
		twenty, because = is an assign-and-replace value. In other words, it replaces the value with 
		which C was initially assigned and replaces it with the sum of A and B. The bottom equation will 
		come to thirty. If the two equations stay like this, the sum will be forty (because the
		math keeps going). */
		C -= A - B; // This, in order with the other equations, will come out to forty. If by itself, it will come to zero.

	}

		

	
	// Update is called once per frame
	void Update () {
		
	}
}
