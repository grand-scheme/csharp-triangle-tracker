## _Triangle Tracker: C# Edition_  

### _Take three numbers, give a triangle._
### December 8th, 2020_  

#### Description:

This C# program interfaces with the user via the command console. In it, the user will be prompted to supply three number values. If the three numbers create a triangle, the program will inform them which type of triangle it is:
- Equilateral, where all three sides have the same length;
- Isosceles, where only two sides have the same length;
- or Scalene, where all sides are of different lengths.

#### Project Criteria:  

As referenced from the [Epicodus](https://epicodus.com) program's curriculum:  

> Create a Triangle Tracker console application similar to the Triangle Tracker website we made [in Intro](https://www.learnhowtoprogram.com/introduction-to-programming/javascript-and-jquery/practice-triangle-tracker).
>
>    Make a console app with a `Triangle` class.
>
>    Use `Console.ReadLine()` to gather three numbers from the user.
>
>    Create a method in the `Triangle` class that takes these 3 numbers and returns what type of triangle (if any) they form:
>        Equilateral: All sides are equal;
>        Isosceles: Exactly 2 sides are equal;
>        Scalene: No sides are equal.
>
>    Not all combinations make valid triangles. If any side is longer than the other two sides combined, the lengths _cannot_ form a triangle. For example, 2, 2, and 8 does not make a triangle. Make sure to account for this.
>
>    **Write plain English spec descriptions first,** including both an input and desired output for each test.

-------------------------------

#### Project Specs:  

All tests can be viewed in `Triangle.Solution/Triangle.Tests/ModelTests/TriangleTests.cs`. 

------------------------------

#### Known Issues / Bugs:    
None that we are aware of.

-------------------------------

#### Setup:  

##### To download to your machine via browser:  
1. Find the green **Code** button above the file list on this project's [main GitHub repository page](https://github.com/grand-scheme/csharp-triangle-tracker/ ).
2. Select the button to open a drop-down menu. Select "Open with GitHub Desktop" or, if you do not have this program installed, download the compressed .zip file.
3. Extract the .zip file to your local machine.
4. Directions were accurate as of December 8th. If GitHub has since changed their protocol, please see [the GitHub help docs](https://docs.github.com/en) for up-to-date information.

##### To clone this project to your machine via console:  
1. Launch your terminal of choice. 
> The following directions are based on Git Bash for a Windows machine; you may have to adjust terminology based on your local specs.

2. Navigate to the containing directory you would like to clone this project.

3. Input:\
`$ git clone https://github.com/grand-scheme/csharp-triangle-tracker/`

4. This will clone the project to a folder called "csharp-triangle-tracker/." If you wish to clone it into a directory of a different name, append the new folder name to the end of the string, like so:\
`$ git clone https://github.com/grand-scheme/csharp-triangle-tracker/ NEW-FOLDER`\
where `NEW-FOLDER` is where you would type the name of the folder you would like to use.  

5. Directions were accurate as of December 8th. If GitHub has since changed their protocol, please see [the GitHub help docs](https://docs.github.com/en) for up-to-date information.

#### To run this project on your machine:
1. Once you have the project locally stored, navigate to its main directory in your terminal of choice. By default, this is `csharp-triangle-tracker/`.

2. In your console terminal of choice, navigate to the directory subfolder `Triangle.Solution/Triangle`.

3. Input command `$ dotnet run`. The console will prompt you to input variables for the program to calculate, and should print to console what type of triangle you have created, if any.

-------------------------------

#### Technologies Used:  
- C# coded in Visual Studio Code.  

##### License
- _GNU AGPLv3_  
- Project copyright (c) 2020 **_Shannon Grantski_** & **_Nataliya Zhuravleva_**
- Project criteria quoted text copyright (c) 2020 Epicodus, Inc  