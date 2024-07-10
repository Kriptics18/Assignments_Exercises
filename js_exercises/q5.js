let names = ["James", "Brennie"];
console.log(names); // ["James", "Brennie"]

names.push("Robert");
console.log(names); // ["James", "Brennie", "Robert"]

let middleIndex = Math.floor(names.length / 2);
names[middleIndex] = "Calvin";
console.log(names); // ["James", "Calvin", "Robert"]


let firstValue = names.shift();
console.log(firstValue); // "James"
console.log(names); // ["Calvin", "Robert"]

names.unshift("Rose", "Regal");
console.log(names); // ["Rose", "Regal", "Calvin", "Robert"]
