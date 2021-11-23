#!/usr/bin/bash

mkdir "exercise"
cd exercise
touch exercise1.txt
echo "Peace is a lie, there is only passion. Through passion I gain strength. Through strength I gain power. Through power I gain victory. Through victory my chains are broken." > exercise1.txt

#Creating an indexed array called list

declare -a list

#Printing the odd numbers from 1-20 into the file

for (( i=1; i<=20; i+=2 ))
do
	echo $i >> exercise1.txt
done

#Adding the even numbers from 1-20 into the array 'list'

for n in {2..20..2}
do
	if (($n==20))
	then
		list+=($n)
	else
		list+=($n,)
	fi
done

#Printing the array into a single line
echo "${list[@]}" >> exercise1.txt

git add exercise1.txt
git commit -m "Woohoo"
git push