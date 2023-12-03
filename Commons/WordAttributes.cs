using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumblr_v3.a.Commons
{
    public class WordAttributes : AttributesBase
    {
        public static WordAttributes[] GetArrayOfEasyWords()
        {
            WordAttributes[] WordsInfo = new WordAttributes[]
            {
                new WordAttributes{WORD = "binary", HINT = "A system of using two digits, 0 and 1, to represent data"},
                new WordAttributes{WORD = "bit", HINT = "The smallest unit of information in a computer"},
                new WordAttributes{WORD = "byte", HINT = "A group of eight bits"},
                new WordAttributes{WORD = "code", HINT = "A set of instructions for a computer to follow"},
                new WordAttributes{WORD = "apple", HINT = "A round, pomaceous fruit of the rose family, typically having a bright red or yellow skin and a crisp flesh."},
                new WordAttributes{WORD = "bird", HINT = "A warm-blooded vertebrate animal distinguished by feathers, toothless beaked jaws, the laying of hard-shelled eggs, a high metabolic rate, a four-chambered heart, and a well-developed forebrain."},
                new WordAttributes{WORD = "cat", HINT = "A small carnivorous mammal with a soft furry coat, a long tail, and retractable claws."},
                new WordAttributes{WORD = "dog", HINT = "A domesticated carnivorous mammal that typically has a long tail, an acute sense of smell, and a barking, howling, or whining voice."},
                new WordAttributes{WORD = "elephant", HINT = "The largest land animal, characterized by its long trunk, tusks, and large ears."},
                new WordAttributes{WORD = "flower", HINT = "The reproductive structure of a flowering plant, consisting of a stalk, a receptacle, petals, stamens, and a pistil."},
                new WordAttributes{WORD = "fish", HINT = "Any of a large, diverse group of cold-blooded aquatic animals with gills or other respiratory organs and fins or other means of locomotion."},
                new WordAttributes{WORD = "frog", HINT = "A tailless amphibian with a smooth, moist skin, strong legs for jumping, and a short body."},
                new WordAttributes{WORD = "girl", HINT = "A young female human being."},
                new WordAttributes{WORD = "horse", HINT = "A large, strong mammal with four hooves, typically used for riding or pulling carts or carriages."},
                new WordAttributes{WORD = "house", HINT = "A building designed for human habitation."},
                new WordAttributes{WORD = "ice", HINT = "The solid form of water."},
                new WordAttributes{WORD = "key", HINT = "A small metal object with notches or teeth that is used to operate a lock."},
                new WordAttributes{WORD = "milk", HINT = "A liquid produced by the mammary glands of mammals to nourish their young."},
                new WordAttributes{WORD = "moon", HINT = "The natural satellite of the Earth, visible at night by its reflected sunlight."},
                new WordAttributes{WORD = "mouth", HINT = "The opening at the front of the head through which food is taken in and speech is produced."},
                new WordAttributes{WORD = "nest", HINT = "A structure built by birds to lay their eggs and raise their young."},
                new WordAttributes{WORD = "nose", HINT = "The part of an animal's face that contains the nostrils and is used for smelling."},
                new WordAttributes{WORD = "ocean", HINT = "A vast body of salt water covering most of the Earth's surface."},
                new WordAttributes{WORD = "orange", HINT = "A round citrus fruit with a thick, orange-colored skin and a juicy, orange-colored flesh."},
                new WordAttributes{WORD = "pen", HINT = "A writing implement with a point that delivers ink to the writing surface."},
                new WordAttributes{WORD = "pig", HINT = "A domesticated omnivorous mammal with a thick, hairless skin, a short snout, and a curled tail."},
                new WordAttributes{WORD = "rain", HINT = "Water falling from the clouds as drops."},
                new WordAttributes{WORD = "river", HINT = "A large natural stream of water that flows through a land and eventually into a larger body of water, such as an ocean or a lake."},
                new WordAttributes{WORD = "sun", HINT = "The star at the center of the solar system, providing light and heat to the planets."},
                new WordAttributes{WORD = "table", HINT = "A piece of furniture with a flat top and one or more legs, used as a surface for eating, writing, or working at."},
                new WordAttributes{WORD = "tree", HINT = "A woody plant with a single stem or trunk, usually growing to a considerable height and supporting a mass of foliage."},
                new WordAttributes{WORD = "umbrella", HINT = "A collapsible circular device that is held over the head to provide protection from rain or sun."},
                new WordAttributes{WORD = "water", HINT = "A clear, colorless, odorless, and tasteless liquid that is the essential constituent of living organisms."},
                new WordAttributes{WORD = "window", HINT = "An opening in a wall or door that is fitted with glass or some other transparent material to admit light and allow people to see out."},
                new WordAttributes{WORD = "car", HINT = "A motor vehicle with four wheels, used for transporting passengers or goods."},
                new WordAttributes{WORD = "boat", HINT = "A small, open vessel for traveling on water."},
                new WordAttributes{WORD = "loop", HINT = "A sequence of instructions that is repeated until a certain condition is met"},
                new WordAttributes{WORD = "bike", HINT = "A two-wheeled vehicle propelled by the rider's feet."},
                new WordAttributes{WORD = "bus", HINT = "A large motor vehicle for carrying passengers by road."},
                new WordAttributes{WORD = "train", HINT = "A railway vehicle or a connected series of railway vehicles that moves on tracks to transport passengers or goods."},
                new WordAttributes{WORD = "airplane", HINT = "A heavier-than-air aircraft that is powered by an engine or engines and is able to maintain flight by the action of air passing over its wings."},
                new WordAttributes{WORD = "ball", HINT = "A spherical object used in games and sports."},
                new WordAttributes{WORD = "doll", HINT = "A small figure of a child, usually a girl, made of materials such as plastic, cloth, or porcelain."},
                new WordAttributes{WORD = "teddy bear", HINT = "A soft toy bear."},
                new WordAttributes{WORD = "wind", HINT = "Air in motion"},
                new WordAttributes{WORD = "banana", HINT = "A curved, yellow fruit with a sweet taste."},
                new WordAttributes{WORD = "light", HINT = "The form of energy that enables us to see."},
                new WordAttributes{WORD = "phone", HINT = "A device used to communicate with others over a long distance."},
                new WordAttributes{WORD = "remote", HINT = "A device used to control something from a distance."},
                new WordAttributes{WORD = "dam", HINT = "A barrier constructed across a waterway to control the flow or raise the level of water."},
                new WordAttributes{WORD = "atom", HINT = "The smallest unit of matter that has the properties of a chemical element"},
                new WordAttributes{WORD = "force", HINT = "A push or pull that can change the motion of an object"},
                new WordAttributes{WORD = "gravity", HINT = "The force that attracts any two objects with mass"},
                new WordAttributes{WORD = "matter", HINT = "Anything that has mass and takes up space"},
                new WordAttributes{WORD = "motion", HINT = "The change in position of an object over time"},
                new WordAttributes{WORD = "physics", HINT = "The study of matter, energy, and their interactions"},
                new WordAttributes{WORD = "plant", HINT = "A living organism that is multicellular, typically photosynthetic, and has no specialized organs for movement"},
                new WordAttributes{WORD = "science", HINT = "The study of the natural world, including physics, chemistry, biology, geology, and astronomy"},
                new WordAttributes{WORD = "space", HINT = "The vast expanse in which all matter and energy exist"},
                new WordAttributes{WORD = "star", HINT = "A fixed luminous point in the night sky, viewed from Earth as a tiny twinkling dot"},
                new WordAttributes{WORD = "video game", HINT = "A game played on a computer or electronic device"}
            };
            return WordsInfo;
        }
        public static WordAttributes[] GetArrayOfDifficultWords()
        {
            WordAttributes[] WordsInfo = new WordAttributes[]
            {
                new WordAttributes{WORD = "algorithm", HINT = "A set of instructions for solving a problem"},
                new WordAttributes{WORD = "application", HINT = "A software program designed to perform a specific task"},
                new WordAttributes{WORD = "compiler", HINT = "A program that converts source code into machine code"},
                new WordAttributes{WORD = "compression", HINT = "The process of reducing the size of a file"},
                new WordAttributes{WORD = "database", HINT = "A collection of organized data"},
                new WordAttributes{WORD = "debugging", HINT = "The process of finding and fixing errors in a program"},
                new WordAttributes{WORD = "encryption", HINT = "The process of converting data into a secret code"},
                new WordAttributes{WORD = "flowchart", HINT = "A diagram that represents the flow of information in a computer program"},
                new WordAttributes{WORD = "formatting", HINT = "The process of organizing and arranging data"},
                new WordAttributes{WORD = "function", HINT = "A block of code that performs a specific task"},
                new WordAttributes{WORD = "hardware", HINT = "The physical parts of a computer"},
                new WordAttributes{WORD = "interface", HINT = "A point of contact between two systems"},
                new WordAttributes{WORD = "iteration", HINT = "The repetition of a process"},
                new WordAttributes{WORD = "memory", HINT = "The storage space in a computer"},
                new WordAttributes{WORD = "network", HINT = "A group of computers that are connected to each other"},
                new WordAttributes{WORD = "object", HINT = "A data structure that contains data and methods"},
                new WordAttributes{WORD = "parameter", HINT = "A variable that is passed to a method"},
                new WordAttributes{WORD = "pointer", HINT = "A variable that stores the address of another variable"},
                new WordAttributes{WORD = "protocol", HINT = "A set of rules for how two computers communicate"},
                new WordAttributes{WORD = "query", HINT = "A request for information from a database"},
                new WordAttributes{WORD = "recursion", HINT = "A method that calls itself"},
                new WordAttributes{WORD = "semantics", HINT = "The meaning of a program"},
                new WordAttributes{WORD = "syntax", HINT = "The structure of a program"},
                new WordAttributes{WORD = "variable", HINT = "A name that is used to store a value"},
                new WordAttributes{WORD = "virtual machine", HINT = "A software program that imitates a hardware machine"},
                new WordAttributes{WORD = "web page", HINT = "A document that can be accessed on the World Wide Web"},
                new WordAttributes{WORD = "web server", HINT = "A computer that stores and delivers web pages"},
                new WordAttributes{WORD = "xml", HINT = "A language for storing and exchanging data"},
                new WordAttributes{WORD = "archipelago", HINT = "A group of islands"},
                new WordAttributes{WORD = "astronomy", HINT = "The study of celestial objects"},
                new WordAttributes{WORD = "calligraphy", HINT = "The art of writing with a pen or brush"},
                new WordAttributes{WORD = "camaraderie", HINT = "A feeling of mutual friendship and support"},
                new WordAttributes{WORD = "charisma", HINT = "A compelling charm that inspires devotion in others"},
                new WordAttributes{WORD = "chronology", HINT = "The arrangement of events in time order"},
                new WordAttributes{WORD = "choreography", HINT = "The art of creating dance steps"},
                new WordAttributes{WORD = "cryptography", HINT = "The science of concealing information"},
                new WordAttributes{WORD = "dialect", HINT = "A regional variation of a language"},
                new WordAttributes{WORD = "diplomacy", HINT = "The art of conducting negotiations and maintaining peaceful relations between nations"},
                new WordAttributes{WORD = "etymology", HINT = "The origin and development of words"},
                new WordAttributes{WORD = "equestrian", HINT = "A person who rides horses"},
                new WordAttributes{WORD = "folklore", HINT = "Traditional beliefs and stories passed down from generation to generation"},
                new WordAttributes{WORD = "gastronomy", HINT = "The art of cooking and preparing food"},
                new WordAttributes{WORD = "geology", HINT = "The study of the Earth's physical structure and composition"},
                new WordAttributes{WORD = "herpetology", HINT = "The study of reptiles and amphibians"},
                new WordAttributes{WORD = "hydrology", HINT = "The study of the distribution and movement of water on Earth's surface and underground"},
                new WordAttributes{WORD = "linguistics", HINT = "The scientific study of language"},
                new WordAttributes{WORD = "meteorology", HINT = "The study of weather and weather forecasting"},
                new WordAttributes{WORD = "musicology", HINT = "The study of music"},
                new WordAttributes{WORD = "numismatics", HINT = "The study of coins and currency"},
                new WordAttributes{WORD = "ornithology", HINT = "The study of birds"},
                new WordAttributes{WORD = "paleontology", HINT = "The study of prehistoric life"},
                new WordAttributes{WORD = "philately", HINT = "The study of postage stamps"},
                new WordAttributes{WORD = "photography", HINT = "The art of creating images by recording light with a camera"},
                new WordAttributes{WORD = "physiognomy", HINT = "The study of facial features and their relationship to character"},
                new WordAttributes{WORD = "seismology", HINT = "The study of earthquakes"},
                new WordAttributes{WORD = "stenography", HINT = "A system of shorthand writing"},
                new WordAttributes{WORD = "taxonomy", HINT = "The classification of organisms"},
                new WordAttributes{WORD = "typography", HINT = "The art of arranging type to make it readable and visually appealing"},
                new WordAttributes{WORD = "ventriloquy", HINT = "The art of speaking without moving one's lips"},
                new WordAttributes{WORD = "xenology", HINT = "The study of extraterrestrial life"},
                new WordAttributes{WORD = "zoology", HINT = "The study of animals"}
            };
            return WordsInfo;
        }
        public override string ToString()
        {
            return $"{WORD}\n{HINT}";
        }
    }
}
