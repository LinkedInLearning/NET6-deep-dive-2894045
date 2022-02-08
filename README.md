# .NET 6 Deep Dive
This is the repository for the LinkedIn Learning course .NET 6 Deep Dive. The full course is available from [LinkedIn Learning][lil-course-url].

![.NET 6 Deep Dive][lil-thumbnail-url] 

This course takes a deep look into the changes to .NET with the release of .NET 6, the latest release of the Microsoft cross-platform, open-source framework. Instructor Walt Ritscher takes you through changes to .NET commands, language improvements to C++ and C#, web applications like Blazor and Visual Studio, and targeting multiple platforms. He also shows you how to edit code and use the Hot Reload feature to apply changes without restarting the application.

## Instructions
This repository has branches for each of the videos in the course. You can use the branch pop up menu in github to switch to a specific branch and take a look at the course at that stage, or you can add `/tree/BRANCH_NAME` to the URL to go to the branch you want to access.

## Branches
The branches are structured to correspond to the videos in the course. The naming convention is `CHAPTER#_MOVIE#`. As an example, the branch named `02_03` corresponds to the second chapter and the third video in that chapter. 
Some branches will have a beginning and an end state. These are marked with the letters `b` for "beginning" and `e` for "end". The `b` branch contains the code as it is at the beginning of the movie. The `e` branch contains the code as it is at the end of the movie. The `main` branch holds the final state of the code when in the course.

When switching from one exercise files branch to the next after making changes to the files, you may get a message like this:

    error: Your local changes to the following files would be overwritten by checkout:        [files]
    Please commit your changes or stash them before you switch branches.
    Aborting

To resolve this issue:
	
    Add changes to git using this command: git add .
	Commit changes using this command: git commit -m "some message"

## Installing
1. To use these exercise files, you must have the following installed:
	- [list of requirements for course]
2. Clone this repository into your local machine using the terminal (Mac), CMD (Windows), or a GUI tool like SourceTree.
3. [Course-specific instructions]


### Instructor

Walt Ritscher 
                            
Senior Staff Author

                            

Check out my other courses on [LinkedIn Learning](https://www.linkedin.com/learning/instructors/walt-ritscher).

[lil-course-url]: https://www.linkedin.com/learning/dot-net-6-deep-dive
[lil-thumbnail-url]: https://cdn.lynda.com/course/3011647/3011647-1643913748473-16x9.jpg
