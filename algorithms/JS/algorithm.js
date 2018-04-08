function findSingleInt (numArr) {
	if (numArr.length % 2 !== 0) {
		let midIndex = Math.floor(numArr.length / 2);

		if(numArr.slice(midIndex).length - 1 % 2 !== 0) {
			let newArr = numArr.slice(0, midIndex + 1);
			console.log(newArr);
			while(true){
				if(newArr[newArr.length - 1] !== newArr[newArr.length - 2]) {
					// how to find the correct unmatching int to return
					
					return newArr[newArr.length - 1];
				} else if (newArr[newArr.length - 1] == newArr[newArr.length - 2]) {
					midIndex = Math.floor(newArr.length / 2);
					newArr = newArr.slice(0, midIndex + 1);
				}
			}
		}
		else {
			return "even";
		}
	}
	else {
		return "A single integar cannot exist";
	}
}

console.log(findSingleInt([1,2,2,3,3]));

// function duplicate(num) {
// 	var temp = num[num.length-1];
//   var index = temp - 1;
//
//   while(true) {
//   	if(temp == num[index]) {
//     	return "duplicate value " + temp;
//     } else {
//     	temp = num[index];
//     	num[index] = temp;
//     }
//   }
// }
//
// console.log(duplicate([3,2,1,4,1]));
