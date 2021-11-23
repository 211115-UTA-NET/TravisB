#!usr/bin/bash

#Prompt the user
echo "Enter the filename you would like to add"

#Accept user input
read filename

#Filter only .txt, .md, .sh, and .png files

#Save the extension abbreviation as ext
ext="${filename##*.}"

#Testing ext against accepted file types
if [[ $ext == "txt" || $ext == "md" || $filetype == "sh" || $filetype == "png" ]]
then

	#add the entered file to staging
	git add $filename

	#Prompt user for commit message
	echo "Please enter your commit message

	#Accept user input
	read message

	#commit the staged files
	git commit -m "$message"

	#Push the commit
	git push
else
	echo "That file type is not accepted"
fi