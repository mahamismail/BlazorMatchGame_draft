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
#line 1 "D:\NEU\Intermediate Programming\BlazorMatchGame_draft\BlazorMatchGame\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\NEU\Intermediate Programming\BlazorMatchGame_draft\BlazorMatchGame\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\NEU\Intermediate Programming\BlazorMatchGame_draft\BlazorMatchGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\NEU\Intermediate Programming\BlazorMatchGame_draft\BlazorMatchGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\NEU\Intermediate Programming\BlazorMatchGame_draft\BlazorMatchGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\NEU\Intermediate Programming\BlazorMatchGame_draft\BlazorMatchGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\NEU\Intermediate Programming\BlazorMatchGame_draft\BlazorMatchGame\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\NEU\Intermediate Programming\BlazorMatchGame_draft\BlazorMatchGame\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\NEU\Intermediate Programming\BlazorMatchGame_draft\BlazorMatchGame\_Imports.razor"
using BlazorMatchGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\NEU\Intermediate Programming\BlazorMatchGame_draft\BlazorMatchGame\_Imports.razor"
using BlazorMatchGame.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\NEU\Intermediate Programming\BlazorMatchGame_draft\BlazorMatchGame\Pages\Index.razor"
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
#line 56 "D:\NEU\Intermediate Programming\BlazorMatchGame_draft\BlazorMatchGame\Pages\Index.razor"
       

	// To view details on TASKS A,B & C; scroll down to the end.


	List<string> animalEmoji = new List<string>()
{
		"🐶", "🐶",
		"🐺", "🐺",
		"🐱", "🐱",
		"🐼", "🐼",
		"🐹", "🐹",
		"🐯", "🐯",
		"🐮", "🐮",
		"🐻", "🐻",
	};

	List<string> hiddenEmoji = new List<string>()
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

	List<string> shuffledAnimals = new List<string>();

	protected override void OnInitialized()
	{
		timer = new Timer(100);
		timer.Elapsed += Timer_Tick;

		SetUpGame();
	}

	private void SetUpGame()
	{

		Random random = new Random();
		shuffledAnimals = animalEmoji
			.OrderBy(item => random.Next())
			.ToList();

		matchesFound = 0; // reset matches to zero (A)

		tenthOfSecondsElapsed = 0;
	}

	string lastAnimalFound = string.Empty;
	string lastDescription = string.Empty;
	int lastButtonIndex;
	int matchesFound = 0;
	Timer timer;
	int tenthOfSecondsElapsed = 0;
	string timeDisplay;
	int scoreDisplay = 0; // created to track score of the matches successfully made. (A)

	// if lastAnimalFound is " ", then buttonIndex is animal.
	// if matchIsSucces, then lastButtonIndex and buttonIndex is " "
	// if false, then lastButtonIndex and buttonIndex is "?"

	private void hideAnimalsAgain(int buttonIndex, int lastButtonIndex)
	{
		hiddenEmoji[buttonIndex] = "❔";
		hiddenEmoji[lastButtonIndex] = "❔";
	}

	private void removeAnimals(int buttonIndex, int lastButtonIndex) {

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
			hiddenEmoji[buttonIndex] = animal;

			lastAnimalFound = animal;
			lastDescription = animalDescription;
			lastButtonIndex = buttonIndex;

			timer.Start(); // the timer begins

		}
		else if ((lastAnimalFound == animal) && (animalDescription != lastDescription)) // if second click and it matches the first
		{
			hiddenEmoji[buttonIndex] = animal;
			Task.Delay(1000).ContinueWith(t => removeAnimals(buttonIndex, lastButtonIndex)); // After 1 second make the buttonName disappear. (C)

			lastAnimalFound = string.Empty;
			//lastButtonIndex = -1;

			matchesFound++;
			scoreDisplay = scoreDisplay + 10; // add to the score by 1 on correct match (A)

			if (matchesFound == 8) // if matches found amount to 8, the timer stops and game is reset.
			{
				timer.Stop();
				timeDisplay += " - Play Again?";
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
				scoreDisplay = scoreDisplay -2; // reduce the score by 1 for incorrect match (A)
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


	/*****
	--------------------for TASK A ✅------------------------------------------- 
	Change the game so that the player scores 1 point for every correct match and loses 1 point for every wrong match

	1) Add a integer scoreDisplay variable with initial value of 0. ✅
	2) Add scoreDisplay ++ when lastAnimalFound == animal ✅
	3) Add scoreDisplay -- when lastAnimalFound != animal ✅
	3) Also make sure clicking on the same button does not decrease scoreDisplay. Add an if statement so 
	that score decreases only when animalDescription != lastDescription. ✅
	4) Display this in html and add @scoreDisplay. ✅

	BUG
	When the player gets something wrong, the button they last clicked on does not get unselected. 
	So people may mess this up.

	- In HTML, unselect button after lastAnimalFound != animal.
	- Make it +10 points for one correct match.
	- Make it -2 points for one incorrect match. 

	*****/



	/*****
	----------------------for TASK B-----------------------------------------
	Give multiple options of animals so the player can choose upto 8 animals to use
	in the game.

	1) Create a list called animalEmojiDatabase that contains 20 animals or more.
	2) Make each animal a button.
	3) On click, the animal gets highlighted and is selected.
	4) When 8 animals emojis have been clicked on and selected, the player cannot click on more.
	5) Click on a Selected animal emoji to Unselect it. 
	6) On clicking GO, setUpGame() is called.
	7) All selected animals emojis from animalEmojiDatabase are pushed twice each into the animalEmoji list.

	--------POSSIBLE CODE:-------------
	string[,] animalDatabase = new string[,] // this creates a 2D array with all 16 animal choices (B)
	{ 
		{ "🐶", "🐶" },{ "🐺", "🐺" }, 
		{ "🐱", "🐱" },{ "🐼", "🐼" }, 
		{ "🐻", "🐻" },{ "🐮", "🐮" },
		{ "🐯", "🐯" },{ "🐹", "🐹" },
		{ "🐷", "🐷" },{ "🦊", "🦊" },
		{ "🐗", "🐗" },{ "🦝", "🦝" },
		{ "🦎", "🦎" },{ "🐠", "🐠" },
		{ "🐰", "🐰" },{ "🦄"


		 , "🦄" }
	};

	List<string> animalEmoji = string.Empty; // create an empty List (B)

	// Push the selected 8 animals from the animalDatabase into the animalEmoji list. (B)
	But this needs to be PUSHED in a way that it is converted into a 1D Array/List.

	******/



	/******
	------------------------- For TASK C ✅---------------------------------
	Memory Game: The buttons begin empty. On click button is visible and remains open until the next one is checked. 
	If the next button matches, both buttons should stay open (and maybe turn green/black).
	If next button is incorrect, both buttons become invisible in one second.

	1) Make a variable for button name ✅
	2) Variable starts as an empty string ✅
	3) In the button click function, the animal is placed in the variable. ✅ bug
	4) After a delay of 1 second, call a function that makes the variable empty again ✅ bug
	4) If lastAnimalFound == animal, then the variable stays visible. 
	5) If lastAnimalFound != animal, then the variable goes back to empty. ✅

	BUGS:
	On click, all buttons display the clicked button's animal.

	*******/


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
