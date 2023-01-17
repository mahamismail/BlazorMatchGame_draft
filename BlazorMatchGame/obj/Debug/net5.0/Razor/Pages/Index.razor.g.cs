#pragma checksum "D:\NEU\Intermediate Programming\BlazorMatchGame_draft\BlazorMatchGame\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8336695489e522bef368cc8e89b54dabdcf9afe3"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<style>\r\n\t.container {\r\n\t\twidth: 400px;\r\n\t}\r\n\r\n\tbutton {\r\n\t\twidth: 100px;\r\n\t\theight: 100px;\r\n\t\tfont-size: 50px;\r\n\t}\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
#nullable restore
#line 18 "D:\NEU\Intermediate Programming\BlazorMatchGame_draft\BlazorMatchGame\Pages\Index.razor"
         for (var animalNumber = 0; animalNumber < shuffledAnimals.Count; animalNumber++)
		{
			var animal = shuffledAnimals[animalNumber];
			var uniqueDescription = $"Button #{animalNumber}";


#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-3");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "D:\NEU\Intermediate Programming\BlazorMatchGame_draft\BlazorMatchGame\Pages\Index.razor"
                                    () => ButtonClick(animal, uniqueDescription)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "type", "button");
            __builder.AddAttribute(10, "class", "btn btn-outline-dark");
            __builder.OpenElement(11, "h1");
            __builder.AddContent(12, 
#nullable restore
#line 26 "D:\NEU\Intermediate Programming\BlazorMatchGame_draft\BlazorMatchGame\Pages\Index.razor"
                         buttonName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "D:\NEU\Intermediate Programming\BlazorMatchGame_draft\BlazorMatchGame\Pages\Index.razor"
		}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\t");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "row");
            __builder.OpenElement(16, "h2");
            __builder.AddContent(17, "Matches found: ");
            __builder.AddContent(18, 
#nullable restore
#line 32 "D:\NEU\Intermediate Programming\BlazorMatchGame_draft\BlazorMatchGame\Pages\Index.razor"
                            matchesFound

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\t");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "row");
            __builder.OpenElement(22, "h2");
            __builder.AddContent(23, "Time: ");
            __builder.AddContent(24, 
#nullable restore
#line 35 "D:\NEU\Intermediate Programming\BlazorMatchGame_draft\BlazorMatchGame\Pages\Index.razor"
                   timeDisplay

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\t");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "row");
            __builder.OpenElement(28, "h2");
            __builder.AddContent(29, "Score: ");
            __builder.AddContent(30, 
#nullable restore
#line 38 "D:\NEU\Intermediate Programming\BlazorMatchGame_draft\BlazorMatchGame\Pages\Index.razor"
                    scoreDisplay

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "D:\NEU\Intermediate Programming\BlazorMatchGame_draft\BlazorMatchGame\Pages\Index.razor"
       

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
		" ", " ",
		" ", " ",
		" ", " ",
		" ", " ",
		" ", " ",
		" ", " ",
		" ", " ",
		" ", " ",
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
	int matchesFound = 0;
	Timer timer;
	int tenthOfSecondsElapsed = 0;
	string timeDisplay;
	int scoreDisplay = 0; // created to track score of the matches successfully made. (A)
	string buttonName = string.Empty; // created this variable for the button heading. It is empty by default. (C) 


	private void animalDisappear() // a function to make the buttonName disappear. (C)
	{
		buttonName = string.Empty;
		/*shuffledAnimals = shuffledAnimals
		.Select(a => a.Replace(buttonName, string.Empty))
		.ToList();*/
	}

	// before this function is called, the buttonHeading is empty. (C)
	private void ButtonClick(string animal, string animalDescription)
	{


		if (lastAnimalFound == string.Empty)
		{
			buttonName = animal; // this places the animal string in buttonHeading. It makes the animal visible (C)
			lastAnimalFound = animal;
			lastDescription = animalDescription;

			timer.Start(); // the timer begins

		}
		else if ((lastAnimalFound == animal) && (animalDescription != lastDescription))
		{
			buttonName = animal; // Animal remains visible (C) 

			shuffledAnimals = shuffledAnimals
			.Select(a => a.Replace(animal, string.Empty))
			.ToList();

			lastAnimalFound = string.Empty;

			matchesFound++;
			scoreDisplay++; // add to the score by 1 on correct match (A)

			if (matchesFound == 8) // if matches found amount to 8, the timer stops and game is reset.
			{
				timer.Stop();
				timeDisplay += " - Play Again?";
				SetUpGame();
			}

		}
		else
		{
			buttonName = animal; // this places the animal string in buttonHeading. It makes the animal visible (C)
			lastAnimalFound = string.Empty;

			Task.Delay(1000).ContinueWith(t => animalDisappear()); // After 1 second make the buttonName disappear. (C)

			if (animalDescription != lastDescription) // this statement is added to make sure the score does not reduce, if the same button is clicked again.
			{
				scoreDisplay--; // reduce the score by 1 for incorrect match (A)
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
		{ "🐰", "🐰" },{ "🦄", "🦄" }
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
