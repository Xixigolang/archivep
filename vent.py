

import logging

# 设置日志记录
logging.basicConfig(filename='login.log', level=logging.INFO,
                    format='%(asctime)s - %(levelname)s - %(message)s')

CORRECT_PASSWORD = "1234"
MAX_ATTEMPTS = 10

def login():
    for attempt in range(1, MAX_ATTEMPTS + 1):
        pwd = input(f"Attempt {attempt}/{MAX_ATTEMPTS} - Enter password: ")
        if pwd == CORRECT_PASSWORD:
            print("Login successful!")
            logging.info("User logged in successfully.")
            return
        else:
            print("Incorrect password.")
    print("Too many failed attempts. Exiting.")
    logging.warning("User failed to login after 10 attempts.")

if __name__ == "__main__":
    login()
