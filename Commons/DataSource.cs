using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumblr_v3.a.Commons
{
    public class DataSource : AttributesBase
    {
        public static DataSource[] GetArrayOfEasyWords()
        {
            DataSource[] WordsInfo = new DataSource[]
            {
                new DataSource{WORD = "adjust", HINT = "Make a change or alteration to something."},
                new DataSource{WORD = "bead", HINT = "Small, often spherical, object typically strung together."},
                new DataSource{WORD = "cheer", HINT = "A joyful expression or to express happiness."},
                new DataSource{WORD = "cloud", HINT = "Fluffy masses in the sky, sometimes bring rain."},
                new DataSource{WORD = "dirt", HINT = "Soil or earth, often found in gardens or on the ground."},
                new DataSource{WORD = "east", HINT = "The direction where the sun rises."},
                new DataSource{WORD = "erupt", HINT = "When a volcano blows its top."},
                new DataSource{WORD = "inferno", HINT = "A fiery place of punishment in some beliefs."},
                new DataSource{WORD = "jacket", HINT = "Clothing worn on the upper body, often with sleeves."},
                new DataSource{WORD = "knight", HINT = "A medieval warrior, often associated with chivalry."},
                new DataSource{WORD = "label", HINT = "A piece of paper or material attached to an object, providing information about it."},
                new DataSource{WORD = "miles", HINT = "A unit of distance measurement."},
                new DataSource{WORD = "nature", HINT = "The natural world and its phenomena."},
                new DataSource{WORD = "nudge", HINT = "A gentle push or encouragement."},
                new DataSource{WORD = "quick", HINT = "Fast or rapid."},
                new DataSource{WORD = "reap", HINT = "To harvest or gather, especially crops."},
                new DataSource{WORD = "rescue", HINT = "To save someone from danger or harm."},
                new DataSource{WORD = "smile", HINT = "An expression of happiness, often shown on the face."},
                new DataSource{WORD = "sword", HINT = "A weapon with a long metal blade."},
                new DataSource{WORD = "wasp", HINT = "A stinging insect often found during the summer."},
                new DataSource{WORD = "code", HINT = "Instructions for a computer program."},
                new DataSource{WORD = "data", HINT = "Information processed or stored by a computer."},
                new DataSource{WORD = "mouse", HINT = "Pointing device used with computers."},
                new DataSource{WORD = "pixel", HINT = "Smallest unit of a digital image."},
                new DataSource{WORD = "ram", HINT = "Random Access Memory in a computer."},
                new DataSource{WORD = "server", HINT = "Computer system that provides services to other computers."},
                new DataSource{WORD = "virus", HINT = "Malicious software that can harm a computer."},
                new DataSource{WORD = "webcam", HINT = "Camera used for video conferencing or surveillance."},
                new DataSource{WORD = "router", HINT = "Device for connecting computer networks."},
                new DataSource{WORD = "download", HINT = "Transfer data from the internet to a computer."},
                new DataSource{WORD = "upload", HINT = "Transfer data from a computer to the internet."},
                new DataSource{WORD = "link", HINT = "Connection between two web pages or documents."},
                new DataSource{WORD = "browser", HINT = "Software used to access the internet."},
                new DataSource{WORD = "cache", HINT = "Temporary storage for faster data retrieval."},
                new DataSource{WORD = "login", HINT = "Process of accessing a computer system."},
                new DataSource{WORD = "email", HINT = "Electronic mail for sending messages."},
                new DataSource{WORD = "file", HINT = "Digital document or data storage unit."},
                new DataSource{WORD = "search", HINT = "Look for information on the internet."},
                new DataSource{WORD = "upgrade", HINT = "Improve or enhance a computer system."},
                new DataSource{WORD = "screen", HINT = "Display for visual output on a device."}
            };
            return WordsInfo;
        }
        public static DataSource[] GetArrayOfAverageWords()
        {
            DataSource[] WordsInfo = new DataSource[]
            {
                new DataSource{WORD = "acrobat", HINT = "A performer skilled in gymnastics and agility."},
                new DataSource{WORD = "algorithm", HINT = "A step-by-step procedure or formula for solving a problem."},
                new DataSource{WORD = "artificial", HINT = "Not natural; made or produced by human beings."},
                new DataSource{WORD = "biometrics", HINT = "Using unique body characteristics for identification."},
                new DataSource{WORD = "browser", HINT = "Software for accessing the internet."},
                new DataSource{WORD = "confection", HINT = "Sweet, often sugary, food."},
                new DataSource{WORD = "encrypt", HINT = "Securely encode information."},
                new DataSource{WORD = "firewall", HINT = "A barrier to prevent unauthorized access in a network."},
                new DataSource{WORD = "innovate", HINT = "Introduce new ideas or methods."},
                new DataSource{WORD = "interface", HINT = "The point of interaction between components or systems."},
                new DataSource{WORD = "internet", HINT = "Global network connecting computers worldwide."},
                new DataSource{WORD = "justice", HINT = "Fair treatment or behavior."},
                new DataSource{WORD = "mystery", HINT = "Something difficult or impossible to understand or explain."},
                new DataSource{WORD = "network", HINT = "A system of interconnected elements."},
                new DataSource{WORD = "passion", HINT = "Strong or intense emotion or feeling."},
                new DataSource{WORD = "pleasant", HINT = "Agreeable or enjoyable."},
                new DataSource{WORD = "procedure", HINT = "An established or official way of doing something."},
                new DataSource{WORD = "programming", HINT = "Writing code for computers."},
                new DataSource{WORD = "software", HINT = "Programs and operating information used by a computer."},
                new DataSource{WORD = "ventilate", HINT = "To allow air to circulate in an enclosed area."},
                new DataSource{WORD = "firewall", HINT = "Security system preventing unauthorized access."},
                new DataSource{WORD = "protocol", HINT = "Set of rules for data transmission."},
                new DataSource{WORD = "malware", HINT = "Software designed to harm or exploit computers."},
                new DataSource{WORD = "encryption", HINT = "Secure coding to protect information."},
                new DataSource{WORD = "bandwidth", HINT = "Data transfer capacity of a network."},
                new DataSource{WORD = "syntax", HINT = "Rules governing the structure of code."},
                new DataSource{WORD = "algorithm", HINT = "Step-by-step procedure for problem-solving."},
                new DataSource{WORD = "debugging", HINT = "Identifying and fixing errors in code."},
                new DataSource{WORD = "hyperlink", HINT = "Text or image linking to another resource."},
                new DataSource{WORD = "database", HINT = "Organized collection of data."},
                new DataSource{WORD = "peripheral", HINT = "External device connected to a computer."},
                new DataSource{WORD = "interface", HINT = "Point of interaction between systems."},
                new DataSource{WORD = "latency", HINT = "Time delay in data transmission."},
                new DataSource{WORD = "BIOS", HINT = "Basic Input/Output System in a computer."},
                new DataSource{WORD = "software", HINT = "Programs and operating information used by a computer."},
                new DataSource{WORD = "framework", HINT = "Platform for developing software applications."},
                new DataSource{WORD = "cache memory", HINT = "High-speed storage for frequently accessed data."},
                new DataSource{WORD = "driver", HINT = "Software enabling communication with hardware."},
                new DataSource{WORD = "compiler", HINT = "Software that translates code into machine-readable language."},
                new DataSource{WORD = "repository", HINT = "Centralized location for storing and managing data."}
            };
            return WordsInfo;
        }
        public static DataSource[] GetArrayOfDifficultWords()
        {
            DataSource[] WordsInfo = new DataSource[]
            {
                new DataSource{WORD = "artificial intelligence", HINT = "Computer systems that can perform tasks that typically require human intelligence."},
                new DataSource{WORD = "asynchronous", HINT = "Not synchronized in time."},
                new DataSource{WORD = "augmented reality", HINT = "Technology that superimposes a computer-generated image on a user's view of the real world."},
                new DataSource{WORD = "authenticate", HINT = "Confirming the validity or truth of something."},
                new DataSource{WORD = "blockchain", HINT = "A digital ledger of transactions."},
                new DataSource{WORD = "concatenation", HINT = "Linking things together in a series or chain."},
                new DataSource{WORD = "cryptocurrency", HINT = "Digital or virtual currency that uses cryptography for security."},
                new DataSource{WORD = "cybersecurity", HINT = "Measures taken to protect computer systems against unauthorized access or cyberattacks."},
                new DataSource{WORD = "electromagnetism", HINT = "The interaction of electric currents or fields and magnetic fields."},
                new DataSource{WORD = "encapsulation", HINT = "The process of enclosing something in a capsule."},
                new DataSource{WORD = "engineering", HINT = "The application of scientific and mathematical principles to design and build machines, structures, and more."},
                new DataSource{WORD = "holography", HINT = "Creating three-dimensional images using lasers."},
                new DataSource{WORD = "quantum mechanics", HINT = "The branch of mechanics that deals with the mathematical description of the motion and interaction of subatomic particles, incorporating the concepts of quantization of energy, wave-particle duality, the uncertainty principle, and the correspondence principle."},
                new DataSource{WORD = "internet of things", HINT = "Interconnected devices that can collect and exchange data."},
                new DataSource{WORD = "machine learning", HINT = "A subset of AI where systems can learn and improve from experience without explicit programming."},
                new DataSource{WORD = "nanotechnology", HINT = "Technology manipulating matter on an atomic or molecular scale."},
                new DataSource{WORD = "quantum computing", HINT = "Computing utilizing the principles of quantum theory."},
                new DataSource{WORD = "recursion", HINT = "A process that repeats or refers back to itself."},
                new DataSource{WORD = "telecommunications", HINT = "Communication over a distance by cable, telegraph, phone, or broadcasting."},
                new DataSource{WORD = "virtual reality", HINT = "Simulated experience created by computer technology."},
                new DataSource{WORD = "quantum cryptography", HINT = "Using quantum mechanics for secure communication."},
                new DataSource{WORD = "neuroinformatics", HINT = "Integration of neuroscience and informatics."},
                new DataSource{WORD = "bioinformatics", HINT = "Applying information technology to biological data."},
                new DataSource{WORD = "exascale computing", HINT = "Computing systems capable of a billion billion calculations per second."},
                new DataSource{WORD = "anthropomorphic robotics", HINT = "Robots designed to resemble human form."},
                new DataSource{WORD = "metamaterials", HINT = "Materials engineered to have properties not found in nature."},
                new DataSource{WORD = "neuromorphic computing", HINT = "Designing computer architectures inspired by the human brain."},
                new DataSource{WORD = "photonic computing", HINT = "Using light instead of electrical signals for computation."},
                new DataSource{WORD = "homomorphic encryption", HINT = "Encrypting data in a way that allows computation on encrypted data."},
                new DataSource{WORD = "terahertz technology", HINT = "Technology using frequencies in the terahertz range."},
                new DataSource{WORD = "graphene nanoelectronics", HINT = "Electronic devices using graphene for improved performance."},
                new DataSource{WORD = "quantum entanglement", HINT = "Quantum physics phenomenon linking particles' states."},
                new DataSource{WORD = "swarm robotics", HINT = "Coordination of multiple robots to perform tasks collectively."},
                new DataSource{WORD = "cryogenic computing", HINT = "Computing at extremely low temperatures for enhanced performance."},
                new DataSource{WORD = "telepresence robotics", HINT = "Robots controlled by a human operator from a distance."},
                new DataSource{WORD = "biometric encryption", HINT = "Using biological characteristics for secure data protection."},
                new DataSource{WORD = "explainable AI", HINT = "AI systems designed to provide understandable explanations for their decisions."},
                new DataSource{WORD = "memristor technology", HINT = "Electronic components that can 'remember' changes in electrical resistance."},
                new DataSource{WORD = "photonic crystal", HINT = "Materials that manipulate and control the flow of light."},
                new DataSource{WORD = "quantum teleportation", HINT = "Instantaneous transfer of quantum information between particles."}
            };
            return WordsInfo;
        }
    }
}
