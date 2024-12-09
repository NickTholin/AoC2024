﻿using AoC._2024;

namespace AoC.Tests._2024
{
    public class Day8Tests
    {

        [Fact]
        public void Day8Part2Test()
        {
            string input = @"
............
........0...
.....0......
.......0....
....0.......
......A.....
............
............
........A...
.........A..
............
............";

            var num = Day8.NumberOfAntinodes(input);
            num.Should().Be(34);
        }
    }
}
