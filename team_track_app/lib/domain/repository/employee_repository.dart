import 'package:team_track_app/core/resources/responce_state.dart';
import 'package:team_track_app/domain/entities/emploee.dart';

abstract class EmployeeRepository {
  Future<ResponceState<List<Employee>>> getAllEmployees();

  Future<ResponceState<Employee>> getEmployeById(int id);

  Future<ResponceState<Employee>> updateEmployee(Employee updatedEmployee);

  Future<ResponceState<List<Employee>>> createEmployee(Employee newEmployee);

  Future<ResponceState<List<Employee>>> deleteEmployee(int id);
}
