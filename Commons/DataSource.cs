using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace Jumblr_v3.a.Commons
{
    public class DataSource : AttributesBase
    {
        //Optimized version
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        
        public static List<AttributesBase> LoadWordInfo(string _difficulty)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<AttributesBase>($"SELECT WORDS, HINT FROM TBL_WORDSINFO WHERE DIFFICULTY = '{_difficulty}'", new DynamicParameters());
                return output.ToList();
            }
        }
        private static DataSource[] DataSourceList(List<AttributesBase> _attributesList)
        {
            return _attributesList
                .Select(attributesBase => new DataSource
                {
                    WORDS = attributesBase.WORDS,
                    HINT = attributesBase.HINT
                })
                .ToArray();
        }
        public static DataSource[] GetArrayOfEasyWords()
        {
            List<AttributesBase> attributesList = LoadWordInfo("easy");
            return DataSourceList(attributesList);
        }
        public static DataSource[] GetArrayOfAverageWords()
        {
            List<AttributesBase> attributesList = LoadWordInfo("average");
            return DataSourceList(attributesList);
        }
        public static DataSource[] GetArrayOfDifficultWords()
        {
            List<AttributesBase> attributesList = LoadWordInfo("difficult");
            return DataSourceList(attributesList);
        }

        //original code
        /*public static List<AttributesBase> LoadWordInfo()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<AttributesBase>("SELECT WORDS, HINT FROM TBL_WORDSINFO WHERE DIFFICULTY = 'easy'", new DynamicParameters());
                return output.ToList();
            }
        }
        public static DataSource[] GetArrayOfEasyWords()
        {
            List<AttributesBase> attributesList = LoadWordInfo("easy");
            List<DataSource> dataSourceList = new List<DataSource>();

            foreach (AttributesBase attributesBase in attributesList)
            {
                DataSource dataSource = new DataSource
                {
                    WORDS = attributesBase.WORDS,
                    HINT = attributesBase.HINT
                };

                dataSourceList.Add(dataSource);
            }
            return dataSourceList.ToArray();
        }
        private static DataSource[] DataSourceList(List <AttributesBase> _attributesList)
        {
            List<DataSource> dataSourceList = new List<DataSource>();

            foreach (AttributesBase attributesBase in _attributesList)
            {
                DataSource dataSource = new DataSource
                {
                    WORDS = attributesBase.WORDS,
                    HINT = attributesBase.HINT
                };

                dataSourceList.Add(dataSource);
            }
            return dataSourceList.ToArray(); 
        }

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
                new DataSource{WORDS = "acrobat", HINT = "A performer skilled in gymnastics and agility."},
                new DataSource{WORDS = "algorithm", HINT = "A step-by-step procedure or formula for solving a problem."},
                new DataSource{WORDS = "artificial", HINT = "Not natural; made or produced by human beings."},
                new DataSource{WORDS = "biometrics", HINT = "Using unique body characteristics for identification."},
                new DataSource{WORDS = "browser", HINT = "Software for accessing the internet."},
                new DataSource{WORDS = "confection", HINT = "Sweet, often sugary, food."},
                new DataSource{WORDS = "encrypt", HINT = "Securely encode information."},
                new DataSource{WORDS = "firewall", HINT = "A barrier to prevent unauthorized access in a network."},
                new DataSource{WORDS = "innovate", HINT = "Introduce new ideas or methods."},
                new DataSource{WORDS = "interface", HINT = "The point of interaction between components or systems."},
                new DataSource{WORDS = "internet", HINT = "Global network connecting computers worldwide."},
                new DataSource{WORDS = "justice", HINT = "Fair treatment or behavior."},
                new DataSource{WORDS = "mystery", HINT = "Something difficult or impossible to understand or explain."},
                new DataSource{WORDS = "network", HINT = "A system of interconnected elements."},
                new DataSource{WORDS = "passion", HINT = "Strong or intense emotion or feeling."},
                new DataSource{WORDS = "pleasant", HINT = "Agreeable or enjoyable."},
                new DataSource{WORDS = "procedure", HINT = "An established or official way of doing something."},
                new DataSource{WORDS = "programming", HINT = "Writing code for computers."},
                new DataSource{WORDS = "software", HINT = "Programs and operating information used by a computer."},
                new DataSource{WORDS = "ventilate", HINT = "To allow air to circulate in an enclosed area."},
                new DataSource{WORDS = "firewall", HINT = "Security system preventing unauthorized access."},
                new DataSource{WORDS = "protocol", HINT = "Set of rules for data transmission."},
                new DataSource{WORDS = "malware", HINT = "Software designed to harm or exploit computers."},
                new DataSource{WORDS = "encryption", HINT = "Secure coding to protect information."},
                new DataSource{WORDS = "bandwidth", HINT = "Data transfer capacity of a network."},
                new DataSource{WORDS = "syntax", HINT = "Rules governing the structure of code."},
                new DataSource{WORDS = "algorithm", HINT = "Step-by-step procedure for problem-solving."},
                new DataSource{WORDS = "debugging", HINT = "Identifying and fixing errors in code."},
                new DataSource{WORDS = "hyperlink", HINT = "Text or image linking to another resource."},
                new DataSource{WORDS = "database", HINT = "Organized collection of data."},
                new DataSource{WORDS = "peripheral", HINT = "External device connected to a computer."},
                new DataSource{WORDS = "interface", HINT = "Point of interaction between systems."},
                new DataSource{WORDS = "latency", HINT = "Time delay in data transmission."},
                new DataSource{WORDS = "BIOS", HINT = "Basic Input/Output System in a computer."},
                new DataSource{WORDS = "software", HINT = "Programs and operating information used by a computer."},
                new DataSource{WORDS = "framework", HINT = "Platform for developing software applications."},
                new DataSource{WORDS = "cache memory", HINT = "High-speed storage for frequently accessed data."},
                new DataSource{WORDS = "driver", HINT = "Software enabling communication with hardware."},
                new DataSource{WORDS = "compiler", HINT = "Software that translates code into machine-readable language."},
                new DataSource{WORDS = "repository", HINT = "Centralized location for storing and managing data."}
            };
            return WordsInfo;
        }*/
        /*public static DataSource[] GetArrayOfDifficultWords()
        {
            DataSource[] WordsInfo = new DataSource[]
            {
                new DataSource{WORDS = "artificial intelligence", HINT = "Computer systems that can perform tasks that typically require human intelligence."},
                new DataSource{WORDS = "asynchronous", HINT = "Not synchronized in time."},
                new DataSource{WORDS = "augmented reality", HINT = "Technology that superimposes a computer-generated image on a user's view of the real world."},
                new DataSource{WORDS = "authenticate", HINT = "Confirming the validity or truth of something."},
                new DataSource{WORDS = "blockchain", HINT = "A digital ledger of transactions."},
                new DataSource{WORDS = "concatenation", HINT = "Linking things together in a series or chain."},
                new DataSource{WORDS = "cryptocurrency", HINT = "Digital or virtual currency that uses cryptography for security."},
                new DataSource{WORDS = "cybersecurity", HINT = "Measures taken to protect computer systems against unauthorized access or cyberattacks."},
                new DataSource{WORDS = "electromagnetism", HINT = "The interaction of electric currents or fields and magnetic fields."},
                new DataSource{WORDS = "encapsulation", HINT = "The process of enclosing something in a capsule."},
                new DataSource{WORDS = "engineering", HINT = "The application of scientific and mathematical principles to design and build machines, structures, and more."},
                new DataSource{WORDS = "holography", HINT = "Creating three-dimensional images using lasers."},
                new DataSource{WORDS = "quantum mechanics", HINT = "The branch of mechanics that deals with the mathematical description of the motion and interaction of subatomic particles, incorporating the concepts of quantization of energy, wave-particle duality, the uncertainty principle, and the correspondence principle."},
                new DataSource{WORDS = "internet of things", HINT = "Interconnected devices that can collect and exchange data."},
                new DataSource{WORDS = "machine learning", HINT = "A subset of AI where systems can learn and improve from experience without explicit programming."},
                new DataSource{WORDS = "nanotechnology", HINT = "Technology manipulating matter on an atomic or molecular scale."},
                new DataSource{WORDS = "quantum computing", HINT = "Computing utilizing the principles of quantum theory."},
                new DataSource{WORDS = "recursion", HINT = "A process that repeats or refers back to itself."},
                new DataSource{WORDS = "telecommunications", HINT = "Communication over a distance by cable, telegraph, phone, or broadcasting."},
                new DataSource{WORDS = "virtual reality", HINT = "Simulated experience created by computer technology."},
                new DataSource{WORDS = "quantum cryptography", HINT = "Using quantum mechanics for secure communication."},
                new DataSource{WORDS = "neuroinformatics", HINT = "Integration of neuroscience and informatics."},
                new DataSource{WORDS = "bioinformatics", HINT = "Applying information technology to biological data."},
                new DataSource{WORDS = "exascale computing", HINT = "Computing systems capable of a billion billion calculations per second."},
                new DataSource{WORDS = "anthropomorphic robotics", HINT = "Robots designed to resemble human form."},
                new DataSource{WORDS = "metamaterials", HINT = "Materials engineered to have properties not found in nature."},
                new DataSource{WORDS = "neuromorphic computing", HINT = "Designing computer architectures inspired by the human brain."},
                new DataSource{WORDS = "photonic computing", HINT = "Using light instead of electrical signals for computation."},
                new DataSource{WORDS = "homomorphic encryption", HINT = "Encrypting data in a way that allows computation on encrypted data."},
                new DataSource{WORDS = "terahertz technology", HINT = "Technology using frequencies in the terahertz range."},
                new DataSource{WORDS = "graphene nanoelectronics", HINT = "Electronic devices using graphene for improved performance."},
                new DataSource{WORDS = "quantum entanglement", HINT = "Quantum physics phenomenon linking particles' states."},
                new DataSource{WORDS = "swarm robotics", HINT = "Coordination of multiple robots to perform tasks collectively."},
                new DataSource{WORDS = "cryogenic computing", HINT = "Computing at extremely low temperatures for enhanced performance."},
                new DataSource{WORDS = "telepresence robotics", HINT = "Robots controlled by a human operator from a distance."},
                new DataSource{WORDS = "biometric encryption", HINT = "Using biological characteristics for secure data protection."},
                new DataSource{WORDS = "explainable AI", HINT = "AI systems designed to provide understandable explanations for their decisions."},
                new DataSource{WORDS = "memristor technology", HINT = "Electronic components that can 'remember' changes in electrical resistance."},
                new DataSource{WORDS = "photonic crystal", HINT = "Materials that manipulate and control the flow of light."},
                new DataSource{WORDS = "quantum teleportation", HINT = "Instantaneous transfer of quantum information between particles."}
            };
            return WordsInfo;
        }*/
    }
}
