// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorMatchGame.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\NEU\Intermediate Programming\Week 1\BlazorMatchGame_draft\BlazorMatchGame\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\NEU\Intermediate Programming\Week 1\BlazorMatchGame_draft\BlazorMatchGame\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\NEU\Intermediate Programming\Week 1\BlazorMatchGame_draft\BlazorMatchGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\NEU\Intermediate Programming\Week 1\BlazorMatchGame_draft\BlazorMatchGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\NEU\Intermediate Programming\Week 1\BlazorMatchGame_draft\BlazorMatchGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\NEU\Intermediate Programming\Week 1\BlazorMatchGame_draft\BlazorMatchGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\NEU\Intermediate Programming\Week 1\BlazorMatchGame_draft\BlazorMatchGame\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\NEU\Intermediate Programming\Week 1\BlazorMatchGame_draft\BlazorMatchGame\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\NEU\Intermediate Programming\Week 1\BlazorMatchGame_draft\BlazorMatchGame\_Imports.razor"
using BlazorMatchGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\NEU\Intermediate Programming\Week 1\BlazorMatchGame_draft\BlazorMatchGame\_Imports.razor"
using BlazorMatchGame.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\NEU\Intermediate Programming\Week 1\BlazorMatchGame_draft\BlazorMatchGame\Pages\Index.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "D:\NEU\Intermediate Programming\Week 1\BlazorMatchGame_draft\BlazorMatchGame\Pages\Index.razor"
       
	/*****for TASK B ✅
	Provide multiple options of animal emoji so the player can choose 
	8 animals and then start the game with them */

	List<string> mainAnimalDatabase = new List<string>() //create a database with 24 options of animal emojis (B)
	{
		"🐶", "🐺",
		"🐱", "🐼",
		"🐻", "🐮",
		"🐯", "🐹",
		"🐷", "🦊",
		"🐗", "🦝",
		"🦎", "🐠",
		"🐰", "🦄",
		"🐜", "🦋",
		"🐌", "🦩",
		"🦜", "🦢",
		"🐥", "🦈",
	};

	protected override void OnInitialized() // when the webpage loads do this
	{
		animalDatabase = mainAnimalDatabase.ToList();
		timer = new Timer(100);
		timer.Elapsed += Timer_Tick;
	}


	//Strings for animals
	List<string> animalDatabase = new List<string>(); // temporary string to store animal database
	List<string> animalEmoji = new List<string>(); //create an empty list of string in which the chosen animals can be pushed (B)


	private void pushAnimalToList(string animalToAdd, int DBIndex) // This function is called everytime the player clicks on a animal(B)
	{
		if (animalEmoji.Count < 16) // player can not choose on more than 8 animals (B)
		{
			animalEmoji.Add(animalToAdd);
			animalEmoji.Add(animalToAdd); // one chosen animal pushed twice to have pairs for the game. (B)
			animalDatabase[DBIndex] = ""; // to make sure the same animal is not clicked twice, the animal is removed on click. (B)
		}
	}

	private void unselectAll() // reset the chosen animals. This was an additional think I added along with Task B to make it replayable. However it has a bug and haven't figure out how to solve it (B)
	{
		animalDatabase.Clear(); // clears the temporary database string.
		animalDatabase = mainAnimalDatabase.ToList(); // fill the temporary database string with animals again
		animalEmoji.Clear();
		shuffledAnimals.Clear();// clear 
		timer.Stop(); // stop the timer
	}


	List<string> shuffledAnimals = new List<string>();

	/****** For TASK C ✅
	Memory Game: The buttons begin with ?. On click button is visible and remains open until the next one is checked.
	If the next button matches, both buttons should stay open for 1 second then emptied out.
	If next button is incorrect, they go back to ?. */

	List<string> hiddenEmoji = new List<string>() // Make a list with ? Emoji. (C)
	{
		"❔", "❔",
		"❔", "❔",
		"❔", "❔",
		"❔", "❔",
		"❔", "❔",
		"❔", "❔",
		"❔", "❔",
		"❔", "❔"
	};

	private void SetUpGame()
	{
		scoreDisplay = 0;
		Random random = new Random(); // randomize the positions of all animals on the list.
		shuffledAnimals = animalEmoji
			.OrderBy(item => random.Next())
			.ToList();

		matchesFound = 0; // reset matches to zero (A)

		tenthOfSecondsElapsed = 0; // reset time

		for (var i = 0; i < hiddenEmoji.Count; i++)
		{
			hiddenEmoji[i] = "❔"; // this is to make sure all animals are "❔" when beginning the game. (C)
		}
	}

	/***** 
	*	
	*
	THE MAIN GAME SETUP 
	*
	*
	*****/

	string lastAnimalFound = string.Empty; // variable to keep track of previous animal clicked
	string lastDescription = string.Empty;
	int lastButtonIndex;
	int matchesFound = 0;
	Timer timer;
	int tenthOfSecondsElapsed = 0;
	string timeDisplay;

	/***** for TASK A ✅
	Change the game so that the player scores 10 point for every correct match and loses 2 points for every wrong match
	*****/
	int scoreDisplay = 0; // created to track score of the matches successfully made. (A)

	private void hideAnimalsAgain(int buttonIndex, int lastButtonIndex)
	{
		hiddenEmoji[buttonIndex] = "❔"; //(C)
		hiddenEmoji[lastButtonIndex] = "❔"; //(C)
	}

	private void removeAnimals(int buttonIndex, int lastButtonIndex)
	{

		shuffledAnimals[buttonIndex] = string.Empty;
		shuffledAnimals[lastButtonIndex] = string.Empty;

		hiddenEmoji[buttonIndex] = string.Empty;
		hiddenEmoji[lastButtonIndex] = string.Empty;
	}

	// before this function is called, the buttonHeading is empty. (C)
	private void ButtonClick(string animal, string animalDescription, int buttonIndex)
	{

		if (lastAnimalFound == string.Empty) // first click
		{
			// if lastAnimalFound is " ", then buttonIndex is animal. (C)

			hiddenEmoji[buttonIndex] = animal;

			lastAnimalFound = animal;
			lastDescription = animalDescription;
			lastButtonIndex = buttonIndex;

			timer.Start(); // the timer begins

		}
		else if ((lastAnimalFound == animal) && (animalDescription != lastDescription)) // if second click and it matches the first
		{
			hiddenEmoji[buttonIndex] = animal; // display the animal
			Task.Delay(1000).ContinueWith(t => removeAnimals(buttonIndex, lastButtonIndex)); // After 1 second remove the correct animals. (C)

			lastAnimalFound = string.Empty;

			matchesFound++;
			scoreDisplay = scoreDisplay + 10; // add to the score by 1 on correct match (A)

			if (matchesFound == 8) // if matches found amount to 8, the timer stops and game is reset.
			{
				timer.Stop();
				timeDisplay += " - Good Job!";
				SetUpGame();
			}

		}
		else
		{
			hiddenEmoji[buttonIndex] = animal;
			Task.Delay(1000).ContinueWith(t => hideAnimalsAgain(buttonIndex, lastButtonIndex)); // After 1 second make the buttonName disappear. (C)

			lastAnimalFound = string.Empty;
			//lastButtonIndex = -1;

			if (animalDescription != lastDescription) // this statement is added to make sure the score does not reduce, if the same button is clicked again.
			{
				scoreDisplay = scoreDisplay - 2; // reduce the score by 1 for incorrect match (A)
			}
		}
	}

	private void Timer_Tick(Object source, ElapsedEventArgs e)
	{
		InvokeAsync(() =>
		{
			tenthOfSecondsElapsed++;
			timeDisplay = (tenthOfSecondsElapsed / 10F)
				.ToString("0.0s");
			StateHasChanged();
		});
	}


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
