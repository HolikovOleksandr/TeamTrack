import 'package:team_track_app/models/departaments.dart';

class Employee {
  final int id;
  final String name;
  final String surname;
  final String position;
  final String adress;
  final String email;
  final double salary;
  final String phoneNumber;
  final DateTime birthDate;
  final DateTime hireDate;
  final Departments department;
  final DateTime? liveDate;

  const Employee({
    required this.id,
    required this.name,
    required this.surname,
    required this.position,
    required this.adress,
    required this.email,
    required this.salary,
    required this.phoneNumber,
    required this.birthDate,
    required this.hireDate,
    this.department = Departments.Candidate,
    this.liveDate,
  });

  factory Employee.fromJson(Map<String, dynamic> json) {
    return Employee(
      id: json["id"],
      name: json["name"],
      surname: json["surname"],
      position: json["position"],
      birthDate: DateTime.parse(json["birthDate"]),
      adress: json["adress"],
      email: json["email"],
      phoneNumber: json["phoneNumber"],
      salary: json["salary"],
      hireDate: DateTime.parse(json["hireDate"]),
      liveDate: DateTime.parse(json["liveDate"]),
      department: json["department"],
    );
  }

  Map<String, dynamic> toJson() {
    return {
      "id": id,
      "name": name,
      "surname": surname,
      "position": position,
      "birthDate": birthDate.toIso8601String(),
      "adress": adress,
      "email": email,
      "phoneNumber": phoneNumber,
      "salary": salary,
      "hireDate": hireDate.toIso8601String(),
      "liveDate": liveDate!.toIso8601String(),
      "department": department,
    };
  }
}
